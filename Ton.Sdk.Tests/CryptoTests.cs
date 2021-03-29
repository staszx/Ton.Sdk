namespace Ton.Sdk.Tests
{
    using System;
    using System.Threading.Tasks;
    using Client;
    using Crypto;
    using NUnit.Framework;

    /// <summary>
    ///     The Crypto module testing
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class CryptoTests : TonClientTestCommon
    {
        #region Fields

        /// <summary>
        ///     The master XPRV
        /// </summary>
        private readonly string masterXprv =
            "xprv9s21ZrQH143K25JhKqEwvJW7QAiVvkmi4WRenBZanA6kxHKtKAQQKwZG65kCyW5jWJ8NY9e3GkRoistUjjcpHNsGBUv94istDPXvqGNuWpC";

        /// <summary>
        ///     The mnemonic
        /// </summary>
        private readonly string mnemonic = "abuse boss fly battle rubber wasp afraid hamster guide essence vibrant tattoo";

        #endregion

        #region Methods

        /// <summary>
        ///     Sha256s the test.
        /// </summary>
        [Test]
        public async Task Sha256Test()
        {
            var data = Helpers.Base64Encode("TON is our future");
            var expected = "1e7fd5ec201652b5375e5edf3e86d0513394d2c2004dd506415abf0578261951";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.Sha256(new ParamsOfHash
            {
                Data = data
            });
            this.Check(result.Hash, expected, "sha256 from string");

            data = Helpers.Base64Encode(Helpers.StringToByteArray("544f4e206973206f757220667574757265"));
            result = await client.Crypto.Sha256(new ParamsOfHash
            {
                Data = data
            });
            this.Check(result.Hash, expected, "sha256 from hex");

            data = "VE9OIGlzIG91ciBmdXR1cmU=";
            result = await client.Crypto.Sha256(new ParamsOfHash
            {
                Data = data
            });
            this.Check(result.Hash, expected, "sha256 from base64");
        }

        /// <summary>
        ///     Sha512s the test.
        /// </summary>
        [Test]
        public async Task Sha512Test()
        {
            var data = Helpers.Base64Encode("TON is our future");
            var expected =
                "4c52dd4cefc68319bac5e97c1f0d18ae8194fb0dd8d9e090ba8376834a0756175a9a736d1e69cb1a58d25c3d554b02a2b8ed9c3ae5cbeeccc3277746a363a434";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.Sha512(new ParamsOfHash
            {
                Data = data
            });
            this.Check(result.Hash, expected);
        }

        /// <summary>
        ///     Hdkeys the XPRV from mnemonic test.
        /// </summary>
        [Test]
        public async Task HdkeyXprvFromMnemonicTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.HDKeyXprvFromMnemonic(new ParamsOfHDKeyXPrvFromMnemonic
            {
                Phrase = this.mnemonic
            });
            this.Check(result.Xprv, this.masterXprv);
        }

        /// <summary>
        ///     Hdkeys the secret from XPRV test.
        /// </summary>
        [Test]
        public async Task HdkeySecretFromXprvTest()
        {
            var expected = "0c91e53128fa4d67589d63a6c44049c1068ec28a63069a55ca3de30c57f8b365";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.HDKeySecretFromXprv(new ParamsOfHDKeySecretFromXPrv
            {
                Xprv = this.masterXprv
            });
            this.Check(result.Secret, expected);
        }

        /// <summary>
        ///     Hdkeys the public from XPRV test.
        /// </summary>
        [Test]
        public async Task HdkeyPublicFromXprvTest()
        {
            var expected = "7b70008d0c40992283d488b1046739cf827afeabf647a5f07c4ad1e7e45a6f89";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.HDKeyPublicFromXprv(new ParamsOfHDKeyPublicFromXPrv
            {
                Xprv = this.masterXprv
            });
            this.Check(result.Public, expected);
        }

        /// <summary>
        ///     Hdkeys the derive from XPRV test.
        /// </summary>
        [Test]
        public async Task HdkeyDeriveFromXprvTest()
        {
            var expected = "xprv9uZwtSeoKf1swgAkVVCEUmC2at6t7MCJoHnBbn1MWJZyxQ4cySkVXPyNh7zjf9VjsP4vEHDDD2a6R35cHubg4WpzXRzniYiy8aJh1gNnBKv";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.HDKeyDeriveFromXprv(new ParamsOfHDKeyDeriveFromXPrv
            {
                Xprv = this.masterXprv,
                ChildIndex = 0,
                Hardened = false
            });

            this.Check(result.Xprv, expected);
        }

        /// <summary>
        ///     Hdkeys the derive from XPRV path test.
        /// </summary>
        [Test]
        public async Task HdkeyDeriveFromXprvPathTest()
        {
            var expected = "xprvA1KNMo63UcGjmDF1bX39Cw2BXGUwrwMjeD5qvQ3tA3qS3mZQkGtpf4DHq8FDLKAvAjXsYGLHDP2dVzLu9ycta8PXLuSYib2T3vzLf3brVgZ";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.HDKeyDeriveFromXprvPath(new ParamsOfHDKeyDeriveFromXPrvPath
            {
                Xprv = this.masterXprv,
                Path = "m/44'/60'/0'/0'"
            });

            this.Check(result.Xprv, expected);
        }

        /// <summary>
        ///     Converts the public key to ton safe format test.
        /// </summary>
        [Test]
        public async Task ConvertPublicKeyToTonSafeFormatTest()
        {
            var expected = "PuYGEX9Zreg-CX4Psz5dKehzW9qCs794oBVUKqqFO7aWAOTD";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.ConvertPublicKeyToTonSafeFormat(new ParamsOfConvertPublicKeyToTonSafeFormat
            {
                PublicKey = "06117f59ade83e097e0fb33e5d29e8735bda82b3bf78a015542aaa853bb69600"
            });
            this.Check(result.TonPublicKey, expected);
        }

        /// <summary>
        ///     Signs the and verify test.
        /// </summary>
        [Test]
        public async Task SignAndVerifyTest()
        {
            var expectedSigned = "+wz+QO6l1slgZS5s65BNqKcu4vz24FCJz4NSAxef9lu0jFfs8x3PzSZRC+pn5k8+aJi3xYMA3BQzglQmjK3hA1Rlc3QgTWVzc2FnZQ==";
            var expectedSignature =
                "fb0cfe40eea5d6c960652e6ceb904da8a72ee2fcf6e05089cf835203179ff65bb48c57ecf31dcfcd26510bea67e64f3e6898b7c58300dc14338254268cade103";
            var unsigned = Helpers.Base64Encode("Test Message");
            var keypair = new KeyPair
            {
                Public = "1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e",
                Secret = "56b6a77093d6fdf14e593f36275d872d75de5b341942376b2a08759f3cbae78f"
            };

            using var client = new TonClient(new ClientConfig());
            var signed = await client.Crypto.Sign(new ParamsOfSign
            {
                Keys = keypair,
                Unsigned = unsigned
            });
            this.Check(signed.Signed, expectedSigned, "signed");
            this.Check(signed.Signature, expectedSignature, "signature");
            var verified = await client.Crypto.VerifySignature(new ParamsOfVerifySignature
            {
                Public = keypair.Public,
                Signed = signed.Signed
            });
            this.Check(verified.Unsigned, unsigned, "Verify base64");
            this.Check(Helpers.Base64Decode(verified.Unsigned), Helpers.Base64Decode(unsigned), "Verify text");
        }

        /// <summary>
        ///     Modularpowers the test.
        /// </summary>
        [Test]
        public async Task ModularpowerTest()
        {
            var expected = "63bfdf";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.ModularPower(new ParamsOfModularPower
            {
                Base = "0123456789ABCDEF",
                Exponent = "0123",
                Modulus = "01234567"
            });

            Assert.AreEqual(expected, result.ModularPower);
        }

        /// <summary>
        ///     Factorizes the test.
        /// </summary>
        [Test]
        public async Task FactorizeTest()
        {
            var expected = "{\"factors\":[\"494C553B\",\"53911073\"]}";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.Factorize(new ParamsOfFactorize
            {
                Composite = "17ED48941A08F981"
            });

            this.Check(result, expected);
        }

        /// <summary>
        ///     CRC16s the test.
        /// </summary>
        [Test]
        public async Task Crc16Test()
        {
            uint expected = 43349;
            var data = Helpers.Base64Encode(Helpers.StringToByteArray("0123456789abcdef"));
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.Crc16(new ParamsOfTonCrc16
            {
                Data = data
            });
            Assert.AreEqual(result.Crc, expected);
        }

        /// <summary>
        ///     Generates the rendom bytes test.
        /// </summary>
        [Test]
        public async Task GenerateRendomBytesTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.GenerateRandomBytes(new ParamsOfGenerateRandomBytes
            {
                Length = 32
            });
            Assert.AreEqual(44, result.Bytes.Length);
            var base64 = Helpers.Base64Decode(result.Bytes);
            Assert.AreEqual(32, base64.Length);
        }

        /// <summary>
        ///     Mnemonics the words test.
        /// </summary>
        [Test]
        public async Task MnemonicWordsTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.MnemonicWords(new ParamsOfMnemonicWords());
            Assert.AreEqual(2048, result.Words.Split(' ').Length);
        }

        /// <summary>
        ///     Mnemonics from rendom.
        /// </summary>
        [Test]
        public async Task MnemonicFromRendomTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom());
            Assert.AreEqual(12, result.Phrase.Split(' ').Length);
            uint[] counts = {12u, 15u, 18u, 21u, 24u};
            for (uint i = 1; i < 9; i++)
            {
                foreach (var count in counts)
                {
                    result = await client.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom
                    {
                        Dictionary = i,
                        WordCount = count
                    });

                    Assert.AreEqual(count, result.Phrase.Split(' ').Length);
                }
            }
        }

        /// <summary>
        ///     Mnemonics from entropy test.
        /// </summary>
        [Test]
        public async Task MnemonicFromEntropyTest()
        {
            var expected = "abandon math mimic master filter design carbon crystal rookie group knife young";
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.MnemonicFromEntropy(new ParamsOfMnemonicFromEntropy
            {
                Entropy = "00112233445566778899AABBCCDDEEFF"
            });

            Assert.AreEqual(expected, result.Phrase);
        }

        [Test]
        public async Task MnemonicFromVerifyTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom());
            var valid = await client.Crypto.MnemonicVerify(new ParamsOfMnemonicVerify
            {
                Phrase = result.Phrase
            });
            Assert.AreEqual(true, valid.Valid);
            Assert.AreEqual(12, result.Phrase.Split(' ').Length);
            uint[] counts = {12u, 15u, 18u, 21u, 24u};
            for (uint i = 1; i < 9; i++)
            {
                foreach (var count in counts)
                {
                    result = await client.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom
                    {
                        Dictionary = i,
                        WordCount = count
                    });

                    valid = await client.Crypto.MnemonicVerify(new ParamsOfMnemonicVerify
                    {
                        Phrase = result.Phrase,
                        WordCount = count,
                        Dictionary = i
                    });

                    Assert.AreEqual(true, valid.Valid);
                }
            }

            valid = await client.Crypto.MnemonicVerify(new ParamsOfMnemonicVerify
            {
                Phrase = "one"
            });
            Assert.AreEqual(false, valid.Valid);
        }

        [Test]
        public async Task MnemonicDeriveSignKeysTest()
        {
            var expectedPublicKeyWithoutPath = "PuYTvCuf__YXhp-4jv3TXTHL0iK65ImwxG0RGrYc1sP3H4KS";
            var expectedPublicKeyWithPath = "PubDdJkMyss2qHywFuVP1vzww0TpsLxnRNnbifTCcu-XEgW0";
            var expectedPublicKeyPharseOnly = "PuZhw8W5ejPJwKA68RL7sn4_RNmeH4BIU_mEK7em5d4_-cIx";
            var expectedPublicKeyFromEntropy = "PuZdw_KyXIzo8IksTrERN3_WoAoYTyK7OvM-yaLk711sUIB3";
            using var client = new TonClient(new ClientConfig());
            var mnemonic = await client.Crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom());
            var keyPair = await client.Crypto.MnemonicDeriveSignKeys(new ParamsOfMnemonicDeriveSignKeys
            {
                Phrase = mnemonic.Phrase
            });
            Assert.Greater(keyPair.Public.Length, 0);
            Assert.Greater(keyPair.Secret.Length, 0);
            var phrase =
                "unit follow zone decline glare flower crisp vocal adapt magic much mesh cherry teach mechanic rain float vicious solution assume hedgehog rail sort chuckle";
            keyPair = await client.Crypto.MnemonicDeriveSignKeys(new ParamsOfMnemonicDeriveSignKeys
            {
                Phrase = phrase,
                Dictionary = MnemonicDictionary.Ton,
                WordCount = 24
            });

            var publicSafe = await client.Crypto.ConvertPublicKeyToTonSafeFormat(new ParamsOfConvertPublicKeyToTonSafeFormat
            {
                PublicKey = keyPair.Public
            });
            this.Check(publicSafe.TonPublicKey, expectedPublicKeyWithoutPath, "public key without path");

            keyPair = await client.Crypto.MnemonicDeriveSignKeys(new ParamsOfMnemonicDeriveSignKeys
            {
                Phrase = phrase,
                Path = "m",
                Dictionary = MnemonicDictionary.Ton,
                WordCount = 24
            });

            publicSafe = await client.Crypto.ConvertPublicKeyToTonSafeFormat(new ParamsOfConvertPublicKeyToTonSafeFormat
            {
                PublicKey = keyPair.Public
            });
            this.Check(publicSafe.TonPublicKey, expectedPublicKeyWithPath, "public key with path");

            phrase = "abandon math mimic master filter design carbon crystal rookie group knife young";
            keyPair = await client.Crypto.MnemonicDeriveSignKeys(new ParamsOfMnemonicDeriveSignKeys
            {
                Phrase = phrase
            });

            publicSafe = await client.Crypto.ConvertPublicKeyToTonSafeFormat(new ParamsOfConvertPublicKeyToTonSafeFormat
            {
                PublicKey = keyPair.Public
            });
            this.Check(publicSafe.TonPublicKey, expectedPublicKeyPharseOnly, "public key pharse only");

            var mnemonicEntropy = await client.Crypto.MnemonicFromEntropy(new ParamsOfMnemonicFromEntropy
            {
                Entropy = "2199ebe996f14d9e4e2595113ad1e627"
            });

            keyPair = await client.Crypto.MnemonicDeriveSignKeys(new ParamsOfMnemonicDeriveSignKeys
            {
                Phrase = mnemonicEntropy.Phrase
            });

            publicSafe = await client.Crypto.ConvertPublicKeyToTonSafeFormat(new ParamsOfConvertPublicKeyToTonSafeFormat
            {
                PublicKey = keyPair.Public
            });
            this.Check(publicSafe.TonPublicKey, expectedPublicKeyFromEntropy, "public key with mnemonic from entropy");
        }

        /// <summary>
        ///     Nacls the sign keypair from secret key.
        /// </summary>
        [Test]
        public async Task NaclSignKeypairFromSecretKeyTest()
        {
            var expected = "aa5533618573860a7e1bf19f34bd292871710ed5b2eafa0dcdbb33405f2231c6";
            using var client = new TonClient(new ClientConfig());
            var keypair = await client.Crypto.NaclSignKeypairFromSecretKey(new ParamsOfNaclSignKeyPairFromSecret
            {
                Secret = "8fb4f2d256e57138fb310b0a6dac5bbc4bee09eb4821223a720e5b8e1f3dd674"
            });

            Assert.AreEqual(expected, keypair.Public);
        }

        /// <summary>
        ///     Nacls the sign test.
        /// </summary>
        [Test]
        public async Task NaclSignTest()
        {
            var unsigned = Helpers.Base64Encode("Test Message");
            var secret =
                "56b6a77093d6fdf14e593f36275d872d75de5b341942376b2a08759f3cbae78f1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e";
            var expectedSigned = "+wz+QO6l1slgZS5s65BNqKcu4vz24FCJz4NSAxef9lu0jFfs8x3PzSZRC+pn5k8+aJi3xYMA3BQzglQmjK3hA1Rlc3QgTWVzc2FnZQ==";
            var expectedSignDetached =
                "fb0cfe40eea5d6c960652e6ceb904da8a72ee2fcf6e05089cf835203179ff65bb48c57ecf31dcfcd26510bea67e64f3e6898b7c58300dc14338254268cade103";
            using var client = new TonClient(new ClientConfig());
            var signed = await client.Crypto.NaclSign(new ParamsOfNaclSign
            {
                Unsigned = unsigned,
                Secret = secret
            });
            this.Check(signed.Signed, expectedSigned, "Sign data");

            var opened = await client.Crypto.NaclSignOpen(new ParamsOfNaclSignOpen
            {
                Public = "1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e",
                Signed = signed.Signed
            });

            this.Check(opened.Unsigned, unsigned, "Sign open");

            var signDetached = await client.Crypto.NaclSignDetached(new ParamsOfNaclSign
            {
                Unsigned = unsigned,
                Secret = secret
            });

            this.Check(signDetached.Signature, expectedSignDetached, "Sign detached");

            await this.CheckException(async () =>
            {
                await client.Crypto.NaclSignOpen(new ParamsOfNaclSignOpen
                {
                    Signed = signed.Signed,
                    Public = "0x00"
                });
            }, "NaclSignOpenExceptionTest");
        }

        /// <summary>
        ///     Nacls the box keypair from secret key.
        /// </summary>
        [Test]
        public async Task NaclBoxKeyPairTest()
        {
            using var client = new TonClient(new ClientConfig());
            var keypair = await client.Crypto.NaclBoxKeypair();
            Assert.AreEqual(64, keypair.Public.Length);
            Assert.AreEqual(64, keypair.Secret.Length);
            Assert.AreNotEqual(keypair.Secret, keypair.Public);
        }

        /// <summary>
        ///     Nacls the box and open test.
        /// </summary>
        [Test]
        public async Task NaclBoxKeypairFromSecretKeyTest()
        {
            var expected = "a53b003d3ffc1e159355cb37332d67fc235a7feb6381e36c803274074dc3933a";
            using var client = new TonClient(new ClientConfig());
            var keypair = await client.Crypto.NaclBoxKeyPairFromSecretKey(new ParamsOfNaclBoxKeyPairFromSecret
            {
                Secret = "e207b5966fb2c5be1b71ed94ea813202706ab84253bdf4dc55232f82a1caf0d4"
            });

            Assert.AreEqual(expected, keypair.Public);
        }

        /// <summary>
        ///     Nacls the box and open test.
        /// </summary>
        [Test]
        public async Task NaclBoxAndOpenTest()
        {
            var decrypted = Helpers.Base64Encode("Test Message");
            var nonce = "cd7f99924bf422544046e83595dd5803f17536f5c9a11746";
            var theirPublic = "c4e2d9fe6a6baf8d1812b799856ef2a306291be7a7024837ad33a8530db79c6b";
            var secret = "d9b9dc5033fb416134e5d2107fdbacab5aadb297cb82dbdcd137d663bac59f7f";
            var expectedBox = "li4XED4kx/pjQ2qdP0eR2d/K30uN94voNADxwA==";
            using var client = new TonClient(new ClientConfig());
            var box = await client.Crypto.NaclBox(new ParamsOfNaclBox
            {
                Decrypted = decrypted,
                Nonce = nonce,
                Secret = secret,
                TheirPublic = theirPublic
            });
            this.Check(box.Encrypted, expectedBox, "Create nacl box");

            var opened = await client.Crypto.NaclBoxOpen(new ParamsOfNaclBoxOpen
            {
                Encrypted = box.Encrypted,
                Nonce = nonce,
                TheirPublic = theirPublic,
                Secret = secret
            });
            this.Check(opened.Decrypted, decrypted, "Open nacl box");

            await this.CheckException(async () =>
            {
                await client.Crypto.NaclBox(new ParamsOfNaclBox
                {
                    Decrypted = "0x00",
                    Nonce = nonce,
                    TheirPublic = "",
                    Secret = secret
                });
            }, "NaclBoxExceptionTest");
            await this.CheckException(async () =>
            {
                await client.Crypto.NaclBoxOpen(new ParamsOfNaclBoxOpen
                {
                    Encrypted = box.Encrypted,
                    Nonce = nonce,
                    TheirPublic = theirPublic,
                    Secret = ""
                });
            }, "NaclBoxOpenExceptionTest");
        }

        /// <summary>
        ///     Nacls the secret box and open test.
        /// </summary>
        [Test]
        public async Task NaclSecretBoxAndOpenTest()
        {
            var decrypted = Helpers.Base64Encode("Test Message \' \" {} $=,?");
            var nonce = "2a33564717595ebe53d91a785b9e068aba625c8453a76e45";
            var key = "8f68445b4e78c000fe4d6b7fc826879c1e63e3118379219a754ae66327764bd8";
            var expectedBox = "I6QZteixTdul0K0ldT+/U4QF0t/C1Q8RGyzQ2Hl7886DpW3/DK5ijg==";
            using var client = new TonClient(new ClientConfig());
            var box = await client.Crypto.NaclSecretBox(new ParamsOfNaclSecretBox
            {
                Decrypted = decrypted,
                Nonce = nonce,
                Key = key
            });
            this.Check(box.Encrypted, expectedBox, "Create nacl secret box");
            var opened = await client.Crypto.NaclSecretBoxOpen(new ParamsOfNaclSecretBoxOpen
            {
                Encrypted = box.Encrypted,
                Nonce = nonce,
                Key = key
            });
            this.Check(opened.Decrypted, decrypted, "Open nacl secret box");

            await this.CheckException(async () =>
            {
                await client.Crypto.NaclSecretBox(new ParamsOfNaclSecretBox
                {
                    Decrypted = "0x00",
                    Nonce = nonce,
                    Key = "None"
                });
            }, "NaclSecretBoxExceptionTest");
            await this.CheckException(async () =>
            {
                await client.Crypto.NaclSecretBoxOpen(new ParamsOfNaclSecretBoxOpen
                {
                    Encrypted = box.Encrypted,
                    Nonce = nonce,
                    Key = ""
                });
            }, "NaclSecretBoxOpenExceptionTest");
        }

        /// <summary>
        ///     Scypts the test.
        /// </summary>
        [Test]
        public async Task ScyptTest()
        {
            var password = Helpers.Base64Encode("Test Password");
            var salt = Helpers.Base64Encode("Test Salt");
            var expectedKey =
                "52e7fcf91356eca55fc5d52f16f5d777e3521f54e3c570c9bbb7df58fc15add73994e5db42be368de7ebed93c9d4f21f9be7cc453358d734b04a057d0ed3626d";
            using var client = new TonClient(new ClientConfig());
            var key = await client.Crypto.Scrypt(new ParamsOfScrypt
            {
                Password = password,
                Salt = salt,
                LogN = 10,
                R = 8,
                P = 16,
                DkLen = 64
            });

            Assert.AreEqual(expectedKey, key.Key);
        }

        /// <summary>
        ///     Chacha20s this instance.
        /// </summary>
        [Ignore("not work"),Test]
        public async Task Chacha20Test()
        {
            var key = string.Join("01", 32);
            var salt = Helpers.Base64Encode("Test Salt");
            var nonce = string.Join("ff", 12);
            var data = Helpers.Base64Encode("Message");
            using var client = new TonClient(new ClientConfig()); 
            var encrypted = await client.Crypto.Chacha20(new ParamsOfChacha20 {Data = data, Key = key, Nonce = nonce});
            Console.WriteLine(encrypted);
        }

        /// <summary>
        ///     Exceptionses the test.
        /// </summary>
        [Test]
        public async Task CryptoExceptionsTest()
        {
            using var client = new TonClient(new ClientConfig());
            var crypto = client.Crypto;
            await this.CheckException(async () =>
            {
                await crypto.HDKeyXprvFromMnemonic(new ParamsOfHDKeyXPrvFromMnemonic
                {
                    Phrase = "0"
                });
            }, "HDKeyXprvFromMnemonicExceptionTest");

            await this.CheckException(async () =>
            {
                await crypto.HDKeySecretFromXprv(new ParamsOfHDKeySecretFromXPrv
                {
                    Xprv = ""
                });
            }, "HDKeySecretFromXprvExceptionTest");

            await this.CheckException(async () =>
            {
                await crypto.HDKeyDeriveFromXprv(new ParamsOfHDKeyDeriveFromXPrv
                {
                    Xprv = this.masterXprv,
                    ChildIndex = -1,
                    Hardened = false
                });
            }, "HDKeyDeriveFromXprvExceptionTest");

            await this.CheckException(async () =>
            {
                await crypto.HDKeyDeriveFromXprvPath(new ParamsOfHDKeyDeriveFromXPrvPath
                {
                    Xprv = this.masterXprv,
                    Path = "m/"
                });
            }, "HDKeyDeriveFromXprvPathExceptionTest");

            await this.CheckException(async () =>
            {
                var unsigned = Helpers.Base64Encode("Test message");
                await crypto.Sign(new ParamsOfSign
                {
                    Unsigned = unsigned,
                    Keys = new KeyPair
                    {
                        Public = "1",
                        Secret = "2"
                    }
                });
            }, "SignExceptionTest");

            await this.CheckException(async () =>
            {
                var keypair = new KeyPair
                {
                    Public = "1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e",
                    Secret = "56b6a77093d6fdf14e593f36275d872d75de5b341942376b2a08759f3cbae78f"
                };
                await crypto.VerifySignature(new ParamsOfVerifySignature
                {
                    Signed = "simple",
                    Public = keypair.Public
                });
            }, "VerifySignatureExceptionTest");

            await this.CheckException(async () =>
            {
                await crypto.ModularPower(new ParamsOfModularPower
                {
                    Base = "1",
                    Exponent = "0123",
                    Modulus = "0.2"
                });
            }, "ModularPowerExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.Factorize(new ParamsOfFactorize
                {
                    Composite = "a3"
                });
            }, "FactorizeExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.Crc16(new ParamsOfTonCrc16
                {
                    Data = "0=="
                });
            }, "Crc16ExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.MnemonicWords(new ParamsOfMnemonicWords
                {
                    Dictionary = 100
                });
            }, "MnemonicWordsExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.MnemonicFromRandom(new ParamsOfMnemonicFromRandom
                {
                    WordCount = 0
                });
            }, "MnemonicFromRandomExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.MnemonicFromEntropy(new ParamsOfMnemonicFromEntropy
                {
                    Entropy = "01"
                });
            }, "MnemonicFromEntropyExceptionTest");
            await this.CheckException(async () =>
            {
                await crypto.NaclSignKeypairFromSecretKey(new ParamsOfNaclSignKeyPairFromSecret
                {
                    Secret = "0a"
                });
            }, "NaclSignKeypairFromSecretKeyExceptionTest");
            await this.CheckException(async () =>
            {
                var secret =
                    "56b6a77093d6fdf14e593f36275d872d75de5b341942376b2a08759f3cbae78f1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e";
                await crypto.NaclSign(new ParamsOfNaclSign
                {
                    Unsigned = "0==",
                    Secret = secret
                });
            }, "NaclSignExceptionTest");

            await this.CheckException(async () =>
            {
                var secret =
                    "56b6a77093d6fdf14e593f36275d872d75de5b341942376b2a08759f3cbae78f1869b7ef29d58026217e9cf163cbfbd0de889bdf1bf4daebf5433a312f5b8d6e";
                await crypto.NaclSignDetached(new ParamsOfNaclSign
                {
                    Unsigned = null,
                    Secret = secret
                });
            }, "NaclSignDetachedExceptionTest");

            await this.CheckException(async () =>
            {
                await crypto.NaclBoxKeyPairFromSecretKey(new ParamsOfNaclBoxKeyPairFromSecret
                {
                    Secret = "0x00"
                });
            }, "NaclBoxKeyPairFromSecretKeyExceptionTest");
            await this.CheckException(async () =>
            {
                var password = Helpers.Base64Encode("Test Password");
                await crypto.Scrypt(new ParamsOfScrypt
                {
                    Password = password,
                    LogN = 10,
                    R = 1,
                    P = 1,
                    DkLen = 0
                });
            }, "ScryptExceptionTest");
        }

        #endregion
    }
}