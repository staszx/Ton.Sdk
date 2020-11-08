namespace Ton.Sdk.Tests
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Abi;
    using NUnit.Framework;
    using Processing;

    /// <summary>
    /// The processing tests
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class ProcessingTests : TonClientTestCommon
    {
        #region Methods

        /// <summary>
        ///     Processes the message test.
        /// </summary>
        [Test]
        public async Task ProcessMessageTest()
        {
            var expectedResultDecoded = "{\"out_messages\":[]}";
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("events.tvc", true);
            using var client = new TonClient(this.ClientConfig);
            var keypair = await client.Crypto.GenerateRandomSignKeys();
            var signer = new Signer(keypair.Public, keypair.Secret);
            var callSet = new CallSet("constructor", "{\"public\": \"" + keypair.Public + "\"}", null);
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage
            {
                ContractAbi = new ContractAbi(abi),
                Signer = signer,
                DeploySet = new DeploySet
                {
                    Tvc = tvc
                },
                CallSet = callSet
            };
            var encoded = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            await this.SendParam(client, encoded.Address);
            var result = await client.Processing.ProcessMessage(new ParamsOfProcessMessage
            {
                MessageEncodeParams = paramsOfEncodeMessage,
                SendEvents = false
            });
            Assert.AreEqual(0, result.OutMessages.Length);
            this.Check(result.Decoded, expectedResultDecoded);
        }

        /// <summary>
        ///     Processes the message with events test.
        /// </summary>
        [Test]
        public async Task ProcessMessageWithEventsTest()
        {
            var expectedResultDecoded = "{\"out_messages\":[]}";
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("events.tvc", true);
            using var client = new TonClient(this.ClientConfig);
            var keypair = await client.Crypto.GenerateRandomSignKeys();
            var signer = new Signer(keypair.Public, keypair.Secret);
            var callSet = new CallSet("constructor", "{\"public\": \"" + keypair.Public + "\"}", null);
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage
            {
                ContractAbi = new ContractAbi(abi),
                Signer = signer,
                DeploySet = new DeploySet
                {
                    Tvc = tvc
                },
                CallSet = callSet
            };
            var encoded = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            await this.SendParam(client, encoded.Address);
            var events = new List<string>();
            var result = await client.Processing.ProcessMessage(new ParamsOfProcessMessage
            {
                MessageEncodeParams = paramsOfEncodeMessage,
                SendEvents = true
            }, (param, responseType) => { events.Add(param); });

            await Task.Factory.StartNew(() => Thread.Sleep(5000));
            Assert.Greater(events.Count, 0);
            Assert.AreEqual(0, result.OutMessages.Length);
            this.Check(result.Decoded, expectedResultDecoded);
        }

        /// <summary>
        /// Waits for transaction test.
        /// </summary>
        [Test]
        public async Task WaitForTransactionTest()
        {
            var expectedResultDecoded = "{\"out_messages\":[]}";
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("events.tvc", true);
            using var client = new TonClient(this.ClientConfig);
            var keypair = await client.Crypto.GenerateRandomSignKeys();
            var signer = new Signer(keypair.Public, keypair.Secret);
            var callSet = new CallSet("constructor", "{\"public\": \"" + keypair.Public + "\"}", null);
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage
            {
                ContractAbi = new ContractAbi(abi),
                Signer = signer,
                DeploySet = new DeploySet
                {
                    Tvc = tvc
                },
                CallSet = callSet
            };
            var encoded = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            await this.SendParam(client, encoded.Address);
            var shardBlock = await client.Processing.SendMessage(new ParamsOfSendMessage
            {
                Message = encoded.Message,
                SendEvents = false,
                ContractAbi = new ContractAbi(abi)
            });
            var result = await client.Processing.WaitForTransaction(new ParamsOfWaitForTransaction
            {
                Message = encoded.Message,
                ShardBlockId = shardBlock.ShardBlockId,
                SendEvents = false,
                ContractAbi = new ContractAbi(abi)
            });
            Assert.AreEqual(0, result.OutMessages.Length);
            this.Check(result.Decoded, expectedResultDecoded);
        }

        /// <summary>
        /// Waits for transaction with events test.
        /// </summary>
        [Test]
        public async Task WaitForTransactionWithEventsTest()
        {
            var expectedResultDecoded = "{\"out_messages\":[]}";
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("events.tvc", true);
            using var client = new TonClient(this.ClientConfig);
            var keypair = await client.Crypto.GenerateRandomSignKeys();
            var signer = new Signer(keypair.Public, keypair.Secret);
            var callSet = new CallSet("constructor", "{\"public\": \"" + keypair.Public + "\"}", null);
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage
            {
                ContractAbi = new ContractAbi(abi),
                Signer = signer,
                DeploySet = new DeploySet
                {
                    Tvc = tvc
                },
                CallSet = callSet
            };
            var encoded = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            await this.SendParam(client, encoded.Address);
            var events = new List<string>();
            var shardBlock = await client.Processing.SendMessage(new ParamsOfSendMessage
            {
                Message = encoded.Message,
                SendEvents = true,
                ContractAbi = new ContractAbi(abi)
            }, (param, responseType) => { events.Add(param); });

            await Task.Factory.StartNew(() => Thread.Sleep(2000));
            Assert.Greater(events.Count, 0);
            events.Clear();
            var result = await client.Processing.WaitForTransaction(new ParamsOfWaitForTransaction
            {
                Message = encoded.Message,
                ShardBlockId = shardBlock.ShardBlockId,
                SendEvents = true,
                ContractAbi = new ContractAbi(abi)
            }, (param, responseType) => { events.Add(param); });

            await Task.Factory.StartNew(() => Thread.Sleep(2000));
            Assert.Greater(events.Count, 0);
            Assert.AreEqual(0, result.OutMessages.Length);
            this.Check(result.Decoded, expectedResultDecoded);
        }

        /// <summary>
        ///     Processings the exceptions test.
        /// </summary>
        [Test]
        public async Task ProcessingExceptionsTest()
        {
            await this.CheckException(this.ProcessMessageExceptionTest);
        }

        /// <summary>
        ///     Processes the message exception test.
        /// </summary>
        private async Task ProcessMessageExceptionTest()
        {
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("events.tvc", true);
            using var client = new TonClient(this.ClientConfig);
            var keypair = await client.Crypto.GenerateRandomSignKeys();
            var signer = new Signer(keypair.Public, keypair.Secret);
            var callSet = new CallSet("returnValue", null, "{\"id\": -1}");
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage
            {
                ContractAbi = new ContractAbi(abi),
                Signer = signer,
                DeploySet = new DeploySet
                {
                    Tvc = tvc
                },
                CallSet = callSet
            };
            var encoded = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            paramsOfEncodeMessage.Address = encoded.Address;
            await client.Processing.ProcessMessage(new ParamsOfProcessMessage
            {
                MessageEncodeParams = paramsOfEncodeMessage,
                SendEvents = false
            });
        }

        #endregion
    }
}