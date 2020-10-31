namespace Ton.Sdk.Tests
{
    using System;
    using Abi;
    using Client;
    using Crypto;
    using External;
    using NUnit.Framework;
    using Utils;

    /// <summary>
    ///     The encode message
    /// </summary>
    public class AbiTestscs
    {
        [Test]
        public void EncodeMessageTest()
        {
            string text = "{\"{}\": 2 }";
            using TonClient client = new TonClient(new ClientConfig());

            ParamsOfEncodeMessageBody param = new ParamsOfEncodeMessageBody
            {
                ContractAbi = new ContractAbi(0), 
                Signer = new Signer("4c7c408ff1ddebb8d6405ee979c716a14fdd6cc08124107a61d3c25597099499", "cc8929d635719612a9478b9cd17675a39cfad52d8959e8a177389b8c0b9122a7"), 
                CallSet = new CallSet()
            };
            Console.WriteLine(client.Abi.EncodeMessageBody(param).Result);
        }

        [Test]
        public void AttachSignatureToMessageBodyTest()
        {
            string text = "{\"{}\": 2 }";
            using TonClient client = new TonClient(new ClientConfig());

            ParamsOfAttachSignatureToMessageBody param = new ParamsOfAttachSignatureToMessageBody()
            {
                ContractAbi = new ContractAbi(0),
                Message = "Hello!",
                PublicKey = "4c7c408ff1ddebb8d6405ee979c716a14fdd6cc08124107a61d3c25597099499",
                Signature = ""

            };

            Console.WriteLine(client.Abi.AttachSignatureToMessageBody(param).Result);
        }

        [Test]
        public void DecodeMessageTest()
        {
            string text = "{\"{}\": 2 }";
            using TonClient client = new TonClient(new ClientConfig());
            ParamsOfDecodeMessage p = new ParamsOfDecodeMessage();
            p.ContractAbi = new ContractAbi(0);
            p.Message = "Hello";
            Console.WriteLine(client.Abi.DecodeMessage(p).Result);
        }
    }
}