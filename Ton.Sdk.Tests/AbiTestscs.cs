namespace Ton.Sdk.Tests
{
    using System;
    using System.Threading.Tasks;
    using Abi;
    using Boc;
    using Client;
    using Crypto;
    using Exceptions;
    using NUnit.Framework;

    /// <summary>
    ///     The Abi module testing
    /// </summary>
    public class AbiTestscs : TonClientTestCommon
    {
        #region Fields

        /// <summary>
        ///     The events expire
        /// </summary>
        private readonly long eventsExpire = 1599458404;

        /// <summary>
        ///     The events time
        /// </summary>
        private readonly long eventsTime = 1599458364291;

        /// <summary>
        ///     The keypair
        /// </summary>
        private readonly KeyPair keypair = new KeyPair
        {
            Public = "4c7c408ff1ddebb8d6405ee979c716a14fdd6cc08124107a61d3c25597099499",
            Secret = "cc8929d635719612a9478b9cd17675a39cfad52d8959e8a177389b8c0b9122a7"
        };

        #endregion

        #region Methods

        /// <summary>
        ///     Decodes the message test.
        /// </summary>
        [Test]
        public async Task DecodeMessageTest()
        {
            string[] expected =
            {
                "{\"body_type\":\"Input\",\"name\":\"returnValue\",\"value\":{\"id\":\"0x0\"},\"header\":{\"expire\":1599458404,\"time\":1599458364291,\"pubkey\":\"4c7c408ff1ddebb8d6405ee979c716a14fdd6cc08124107a61d3c25597099499\"}}",
                "{\"body_type\":\"Event\",\"name\":\"EventThrown\",\"value\":{\"id\":\"0x0\"}}",
                "{\"body_type\":\"Output\",\"name\":\"returnValue\",\"value\":{\"value0\":\"0x0\"}}"
            };
            string[] messages =
            {
                "te6ccgEBAwEAvAABRYgAC31qq9KF9Oifst6LU9U6FQSQQRlCSEMo+A3LN5MvphIMAQHhrd/b+MJ5Za+AygBc5qS/dVIPnqxCsM9PvqfVxutK+lnQEKzQoRTLYO6+jfM8TF4841bdNjLQwIDWL4UVFdxIhdMfECP8d3ruNZAXul5xxahT91swIEkEHph08JVlwmUmQAAAXRnJcuDX1XMZBW+LBKACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==",
                "te6ccgEBAQEAVQAApeACvg5/pmQpY4m61HmJ0ne+zjHJu3MNG8rJxUDLbHKBu/AAAAAAAAAMJL6z6ro48sYvAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABA",
                "te6ccgEBAQEAVQAApeACvg5/pmQpY4m61HmJ0ne+zjHJu3MNG8rJxUDLbHKBu/AAAAAAAAAMKr6z6rxK3xYJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABA"
            };
            var abi = new ContractAbi(this.LoadSample("Events.abi.json"));
            using var client = new TonClient(new ClientConfig());
            for (var i = 0; i < messages.Length; i++)
            {
                var p = new ParamsOfDecodeMessage();
                p.ContractAbi = abi;
                p.Message = messages[i];
                var result = await client.Abi.DecodeMessage(p);
                this.Check(result, expected[i]);
            }

            await this.CheckException(async () =>
            {
                await client.Abi.DecodeMessage(new ParamsOfDecodeMessage
                {
                    ContractAbi = abi,
                    Message = "0x0"
                });
            }, "DecodeMessageExceptionTest");
        }

        /// <summary>
        ///     Decodes the message body test.
        /// </summary>
        [Test]
        public async Task DecodeMessageBodyTest()
        {
            var message =
                "te6ccgEBAwEAvAABRYgAC31qq9KF9Oifst6LU9U6FQSQQRlCSEMo+A3LN5MvphIMAQHhrd/b+MJ5Za+AygBc5qS/dVIPnqxCsM9PvqfVxutK+lnQEKzQoRTLYO6+jfM8TF4841bdNjLQwIDWL4UVFdxIhdMfECP8d3ruNZAXul5xxahT91swIEkEHph08JVlwmUmQAAAXRnJcuDX1XMZBW+LBKACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==";
            var expected =
                "{\"body_type\":\"Input\",\"name\":\"returnValue\",\"value\":{\"id\":\"0x0\"},\"header\":{\"expire\":1599458404,\"time\":1599458364291,\"pubkey\":\"4c7c408ff1ddebb8d6405ee979c716a14fdd6cc08124107a61d3c25597099499\"}}";
            using var client = new TonClient(new ClientConfig());
            var parsed = await client.Boc.ParseMessage(new ParamsOfParse
            {
                Boc = message
            });
            var msg = parsed.Parsed["body"].ToString();
            var decoded = await client.Abi.DecodeMessageBody(new ParamsOfDecodeMessageBody
            {
                ContractAbi = new ContractAbi(this.LoadSample("Events.abi.json")),
                Body = msg
            });
            this.Check(decoded, expected);
        }

        /// <summary>
        ///     Encodes the message test.
        /// </summary>
        [Test]
        public async Task EncodeMessageDeploymentTest()
        {
            var expectedUnsignedMessage = "te6ccgECFwEAA2gAAqeIAAt9aqvShfTon7Lei1PVOhUEkEEZQkhDKPgNyzeTL6YSEZTHxAj/Hd67jWQF7peccWoU/dbMCBJBB6YdPCVZcJlJkAAAF0ZyXLg19VzGRotV8/gGAQEBwAICA88gBQMBAd4EAAPQIABB2mPiBH+O713GsgL3S844tQp+62YECSCD0w6eEqy4TKTMAib/APSkICLAAZL0oOGK7VNYMPShCQcBCvSkIPShCAAAAgEgDAoByP9/Ie1E0CDXScIBjhDT/9M/0wDRf/hh+Gb4Y/hijhj0BXABgED0DvK91wv/+GJw+GNw+GZ/+GHi0wABjh2BAgDXGCD5AQHTAAGU0/8DAZMC+ELiIPhl+RDyqJXTAAHyeuLTPwELAGqOHvhDIbkgnzAg+COBA+iogggbd0Cgud6S+GPggDTyNNjTHwH4I7zyudMfAfAB+EdukvI83gIBIBINAgEgDw4AvbqLVfP/hBbo417UTQINdJwgGOENP/0z/TANF/+GH4Zvhj+GKOGPQFcAGAQPQO8r3XC//4YnD4Y3D4Zn/4YeLe+Ebyc3H4ZtH4APhCyMv/+EPPCz/4Rs8LAMntVH/4Z4AgEgERAA5biABrW/CC3Rwn2omhp/+mf6YBov/ww/DN8Mfwxb30gyupo6H0gb+j8IpA3SRg4b3whXXlwMnwAZGT9ghBkZ8KEZ0aCBAfQAAAAAAAAAAAAAAAAACBni2TAgEB9gBh8IWRl//wh54Wf/CNnhYBk9qo//DPAAxbmTwqLfCC3Rwn2omhp/+mf6YBov/ww/DN8Mfwxb2uG/8rqaOhp/+/o/ABkRe4AAAAAAAAAAAAAAAAIZ4tnwOfI48sYvRDnhf/kuP2AGHwhZGX//CHnhZ/8I2eFgGT2qj/8M8AIBSBYTAQm4t8WCUBQB/PhBbo4T7UTQ0//TP9MA0X/4Yfhm+GP4Yt7XDf+V1NHQ0//f0fgAyIvcAAAAAAAAAAAAAAAAEM8Wz4HPkceWMXohzwv/yXH7AMiL3AAAAAAAAAAAAAAAABDPFs+Bz5JW+LBKIc8L/8lx+wAw+ELIy//4Q88LP/hGzwsAye1UfxUABPhnAHLccCLQ1gIx0gAw3CHHAJLyO+Ah1w0fkvI84VMRkvI74cEEIoIQ/////byxkvI84AHwAfhHbpLyPN4=";
            var expectedUnsignedData = "KCGM36iTYuCYynk+Jnemis+mcwi3RFCke95i7l96s4Q=";
            var expectedSignature =
                "6272357bccb601db2b821cb0f5f564ab519212d242cf31961fe9a3c50a30b236012618296b4f769355c0e9567cd25b366f3c037435c498c82e5305622adbc70e";
            var expectedSignedMessage =
                "te6ccgECGAEAA6wAA0eIAAt9aqvShfTon7Lei1PVOhUEkEEZQkhDKPgNyzeTL6YSEbAHAgEA4bE5Gr3mWwDtlcEOWHr6slWoyQlpIWeYyw/00eKFGFkbAJMMFLWnu0mq4HSrPmktmzeeAboa4kxkFymCsRVt44dTHxAj/Hd67jWQF7peccWoU/dbMCBJBB6YdPCVZcJlJkAAAF0ZyXLg19VzGRotV8/gAQHAAwIDzyAGBAEB3gUAA9AgAEHaY+IEf47vXcayAvdLzji1Cn7rZgQJIIPTDp4SrLhMpMwCJv8A9KQgIsABkvSg4YrtU1gw9KEKCAEK9KQg9KEJAAACASANCwHI/38h7UTQINdJwgGOENP/0z/TANF/+GH4Zvhj+GKOGPQFcAGAQPQO8r3XC//4YnD4Y3D4Zn/4YeLTAAGOHYECANcYIPkBAdMAAZTT/wMBkwL4QuIg+GX5EPKoldMAAfJ64tM/AQwAao4e+EMhuSCfMCD4I4ED6KiCCBt3QKC53pL4Y+CANPI02NMfAfgjvPK50x8B8AH4R26S8jzeAgEgEw4CASAQDwC9uotV8/+EFujjXtRNAg10nCAY4Q0//TP9MA0X/4Yfhm+GP4Yo4Y9AVwAYBA9A7yvdcL//hicPhjcPhmf/hh4t74RvJzcfhm0fgA+ELIy//4Q88LP/hGzwsAye1Uf/hngCASASEQDluIAGtb8ILdHCfaiaGn/6Z/pgGi//DD8M3wx/DFvfSDK6mjofSBv6PwikDdJGDhvfCFdeXAyfABkZP2CEGRnwoRnRoIEB9AAAAAAAAAAAAAAAAAAIGeLZMCAQH2AGHwhZGX//CHnhZ/8I2eFgGT2qj/8M8ADFuZPCot8ILdHCfaiaGn/6Z/pgGi//DD8M3wx/DFva4b/yupo6Gn/7+j8AGRF7gAAAAAAAAAAAAAAAAhni2fA58jjyxi9EOeF/+S4/YAYfCFkZf/8IeeFn/wjZ4WAZPaqP/wzwAgFIFxQBCbi3xYJQFQH8+EFujhPtRNDT/9M/0wDRf/hh+Gb4Y/hi3tcN/5XU0dDT/9/R+ADIi9wAAAAAAAAAAAAAAAAQzxbPgc+Rx5YxeiHPC//JcfsAyIvcAAAAAAAAAAAAAAAAEM8Wz4HPklb4sEohzwv/yXH7ADD4QsjL//hDzws/+EbPCwDJ7VR/FgAE+GcActxwItDWAjHSADDcIccAkvI74CHXDR+S8jzhUxGS8jvhwQQighD////9vLGS8jzgAfAB+EdukvI83g==";
            var tvc = this.LoadSample("Events.tvc", true);
            var abi = this.LoadSample("Events.abi.json");
            using var client = new TonClient(new ClientConfig());
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage();
            paramsOfEncodeMessage.CallSet = this.GetCallSet("constructor");
            paramsOfEncodeMessage.DeploySet = new DeploySet
            {
                InitalData = null,
                WorkchainId = 0,
                Tvc = tvc
            };
            paramsOfEncodeMessage.Signer = new Signer(this.keypair.Public);
            paramsOfEncodeMessage.ContractAbi = new ContractAbi(abi);
            var unsigned = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            this.Check(unsigned.Message, expectedUnsignedMessage, "Unsigned message");
            this.Check(unsigned.DataToSign, expectedUnsignedData, "Unsigned data to sign");

            var signature = await client.Crypto.Sign(new ParamsOfSign
            {
                Keys = this.keypair,
                Unsigned = unsigned.DataToSign
            });
            this.Check(signature.Signature, expectedSignature, "Signature");

            var signed = await client.Abi.AttachSignature(new ParamsOfAttachSignature
            {
                ContractAbi = new ContractAbi(abi),
                PublicKey = this.keypair.Public,
                Message = unsigned.Message,
                Signature = signature.Signature
            });
            this.Check(signed.Message, expectedSignedMessage, "Signed");

            var signer = new Signer(this.keypair.Public, this.keypair.Secret);
            paramsOfEncodeMessage.Signer = signer;
            var signedEncodedMsg = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            this.Check(signedEncodedMsg.Message, expectedSignedMessage, "SignedEncoded");
        }

        /// <summary>
        ///     Encodes the message run.
        /// </summary>
        [Test]
        public async Task EncodeMessageRunTest()
        {
            var expectedUnsignedMsg =
                "te6ccgEBAgEAeAABpYgAC31qq9KF9Oifst6LU9U6FQSQQRlCSEMo+A3LN5MvphIFMfECP8d3ruNZAXul5xxahT91swIEkEHph08JVlwmUmQAAAXRnJcuDX1XMZBW+LBKAQBAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=";
            var expectedDataToSign = "i4Hs3PB12QA9UBFbOIpkG3JerHHqjm4LgvF4MA7TDsY=";
            var expectedSignature =
                "5bbfb7f184f2cb5f019400b9cd497eeaa41f3d5885619e9f7d4fab8dd695f4b3a02159a1422996c1dd7d1be67898bc79c6adba6c65a18101ac5f0a2a2bb8910b";
            var expectedSigned =
                "te6ccgEBAwEAvAABRYgAC31qq9KF9Oifst6LU9U6FQSQQRlCSEMo+A3LN5MvphIMAQHhrd/b+MJ5Za+AygBc5qS/dVIPnqxCsM9PvqfVxutK+lnQEKzQoRTLYO6+jfM8TF4841bdNjLQwIDWL4UVFdxIhdMfECP8d3ruNZAXul5xxahT91swIEkEHph08JVlwmUmQAAAXRnJcuDX1XMZBW+LBKACAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==";
            var address = "0:05beb555e942fa744fd96f45a9ea9d0a8248208ca12421947c06e59bc997d309";
            var abi = this.LoadSample("Events.abi.json");
            using var client = new TonClient(new ClientConfig());
            var paramsOfEncodeMessage = new ParamsOfEncodeMessage();
            paramsOfEncodeMessage.CallSet = this.GetCallSet("returnValue", "{\"id\":\"0\"}");
            paramsOfEncodeMessage.Signer = new Signer(this.keypair.Public);
            paramsOfEncodeMessage.ContractAbi = new ContractAbi(abi);
            paramsOfEncodeMessage.Address = address;
            var unsignedMessage = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            this.Check(unsignedMessage.Message, expectedUnsignedMsg, "Unsigned.Message");
            this.Check(unsignedMessage.DataToSign, expectedDataToSign, "unsignedMessage.DataToSign");

            var signature = await client.Crypto.Sign(new ParamsOfSign
            {
                Keys = this.keypair,
                Unsigned = unsignedMessage.DataToSign
            });
            this.Check(signature.Signature, expectedSignature, "Signature");

            var signed = await client.Abi.AttachSignature(new ParamsOfAttachSignature
            {
                ContractAbi = new ContractAbi(abi),
                PublicKey = this.keypair.Public,
                Message = unsignedMessage.Message,
                Signature = signature.Signature
            });
            this.Check(signed.Message, expectedSigned, "Signed");

            var signer = new Signer(this.keypair.Public, this.keypair.Secret);
            paramsOfEncodeMessage.Signer = signer;
            var signedEncodedMsg = await client.Abi.EncodeMessage(paramsOfEncodeMessage);
            this.Check(signedEncodedMsg.Message, expectedSigned, "SignedEncoded");
        }

        /// <summary>
        ///     Encodes the account test.
        /// </summary>
        [Test]
        public async Task EncodeAccountTest()
        {
            var encodedDeployMessage =
                "te6ccgECFwEAA2gAAqeIAAt9aqvShfTon7Lei1PVOhUEkEEZQkhDKPgNyzeTL6YSEZTHxAj/Hd67jWQF7peccWoU/dbMCBJBB6YdPCVZcJlJkAAAF0ZyXLg19VzGRotV8/gGAQEBwAICA88gBQMBAd4EAAPQIABB2mPiBH+O713GsgL3S844tQp+62YECSCD0w6eEqy4TKTMAib/APSkICLAAZL0oOGK7VNYMPShCQcBCvSkIPShCAAAAgEgDAoByP9/Ie1E0CDXScIBjhDT/9M/0wDRf/hh+Gb4Y/hijhj0BXABgED0DvK91wv/+GJw+GNw+GZ/+GHi0wABjh2BAgDXGCD5AQHTAAGU0/8DAZMC+ELiIPhl+RDyqJXTAAHyeuLTPwELAGqOHvhDIbkgnzAg+COBA+iogggbd0Cgud6S+GPggDTyNNjTHwH4I7zyudMfAfAB+EdukvI83gIBIBINAgEgDw4AvbqLVfP/hBbo417UTQINdJwgGOENP/0z/TANF/+GH4Zvhj+GKOGPQFcAGAQPQO8r3XC//4YnD4Y3D4Zn/4YeLe+Ebyc3H4ZtH4APhCyMv/+EPPCz/4Rs8LAMntVH/4Z4AgEgERAA5biABrW/CC3Rwn2omhp/+mf6YBov/ww/DN8Mfwxb30gyupo6H0gb+j8IpA3SRg4b3whXXlwMnwAZGT9ghBkZ8KEZ0aCBAfQAAAAAAAAAAAAAAAAACBni2TAgEB9gBh8IWRl//wh54Wf/CNnhYBk9qo//DPAAxbmTwqLfCC3Rwn2omhp/+mf6YBov/ww/DN8Mfwxb2uG/8rqaOhp/+/o/ABkRe4AAAAAAAAAAAAAAAAIZ4tnwOfI48sYvRDnhf/kuP2AGHwhZGX//CHnhZ/8I2eFgGT2qj/8M8AIBSBYTAQm4t8WCUBQB/PhBbo4T7UTQ0//TP9MA0X/4Yfhm+GP4Yt7XDf+V1NHQ0//f0fgAyIvcAAAAAAAAAAAAAAAAEM8Wz4HPkceWMXohzwv/yXH7AMiL3AAAAAAAAAAAAAAAABDPFs+Bz5JW+LBKIc8L/8lx+wAw+ELIy//4Q88LP/hGzwsAye1UfxUABPhnAHLccCLQ1gIx0gAw3CHHAJLyO+Ah1w0fkvI84VMRkvI74cEEIoIQ/////byxkvI84AHwAfhHbpLyPN4=";
            var expectedEncodedId = "05beb555e942fa744fd96f45a9ea9d0a8248208ca12421947c06e59bc997d309";
            var expectedIdWithoutKey = "84a9510b0278047154b1b84b6dd445c1349d8d42d75a2eece07b72ad6e4ea136";
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("Events.tvc", true);
            var messageSource = new MessageSource(encodedDeployMessage, new ContractAbi(abi));
            var stateInitSource = new StateInitSource(messageSource);
            using var client = new TonClient(new ClientConfig());
            var encoded = await client.Abi.EncodeAccount(new ParamsOfEncodeAccount
            {
                StateInit = stateInitSource
            });
            this.Check(encoded.Id, expectedEncodedId, "Encoded.Id (deploy message)");

            var deploySet = new DeploySet
            {
                Tvc = tvc
            };
            var callSet = this.GetCallSet("constructor");
            var signer = new Signer(this.keypair.Public, this.keypair.Secret);
            messageSource = new MessageSource(new ContractAbi(abi), null, deploySet, callSet, signer);
            stateInitSource = new StateInitSource(messageSource);
            encoded = await client.Abi.EncodeAccount(new ParamsOfEncodeAccount
            {
                StateInit = stateInitSource
            });
            this.Check(encoded.Id, expectedEncodedId, "Encoded.Id (encoding params)");

            stateInitSource = new StateInitSource(tvc);
            encoded = await client.Abi.EncodeAccount(new ParamsOfEncodeAccount
            {
                StateInit = stateInitSource
            });
            this.Check(encoded.Id, expectedIdWithoutKey, "Encoded.Id (tvc without key)");

            stateInitSource = new StateInitSource(tvc, this.keypair.Public, (StateInitParams) null);
            encoded = await client.Abi.EncodeAccount(new ParamsOfEncodeAccount
            {
                StateInit = stateInitSource
            });
            this.Check(encoded.Id, expectedEncodedId, "Encoded.Id (tvc with key)");
        }

        /// <summary>
        ///     Encodes the account exception test.
        /// </summary>
        [Test]
        public async Task EncodeAccountExceptionTest()
        {
            var abi = this.LoadSample("Events.abi.json");
            var tvc = this.LoadSample("Events.tvc", true);
            var deploySet = new DeploySet
            {
                Tvc = tvc
            };
            var signer = new Signer(this.keypair.Public);
            var messageSource = new MessageSource(new ContractAbi(abi), null, deploySet, this.GetCallSet("constructor"), signer);
            var stateInitSource = new StateInitSource(messageSource);
            try
            {
                using var client = new TonClient(new ClientConfig());
                var encoded = await client.Abi.EncodeAccount(new ParamsOfEncodeAccount
                {
                    StateInit = stateInitSource
                });
            }
            catch (TonClientInternalException)
            {
                Console.WriteLine("Exception test success!");
            }
        }

        /// <summary>
        ///     Gets the call set.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="inputs">The inputs.</param>
        /// <returns></returns>
        private CallSet GetCallSet(string functionName, string inputs = null)
        {
            return new CallSet(functionName,
                '{' + string.Format("\"pubkey\":\"{0}\", \"time\":{1}, \"expire\":{2}", this.keypair.Public, this.eventsTime, this.eventsExpire) +
                '}', inputs);
        }

        #endregion
    }
}