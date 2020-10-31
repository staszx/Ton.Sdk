namespace Ton.Sdk.Crypto
{
    using System.Threading.Tasks;

    public class Crypto : TonClientModule

    {
        #region Constructors

        internal Crypto(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Factorizes the specified parameters of factorize.
        /// </summary>
        /// <param name="paramsOfFactorize">The parameters of factorize.</param>
        /// <returns></returns>
        public async Task<ResultOfFactorize> Factorize(ParamsOfFactorize paramsOfFactorize)
        {
            return await this.Request<ResultOfFactorize>("crypto.factorize", paramsOfFactorize);
        }


        /// <summary>
        ///     Modulars the power.
        /// </summary>
        /// <param name="paramsOfModularPower">The parameters of modular power.</param>
        /// <returns></returns>
        public async Task<ResultOfModularPower> ModularPower(ParamsOfModularPower paramsOfModularPower)
        {
            return await this.Request<ResultOfModularPower>("crypto.modular_power", paramsOfModularPower);
        }

        /// <summary>
        ///     Modulars the power.
        /// </summary>
        /// <param name="paramsOfTonCrc16">The parameters of ton CRC16.</param>
        /// <returns></returns>
        public async Task<ResultOfTonCrc16> ModularPower(ParamsOfTonCrc16 paramsOfTonCrc16)
        {
            return await this.Request<ResultOfTonCrc16>("crypto.ton_crc16", paramsOfTonCrc16);
        }

        /// <summary>
        ///     Generates the random bytes.
        /// </summary>
        /// <param name="paramsOfGenerateRandomBytes">The parameters of generate random bytes.</param>
        /// <returns></returns>
        public async Task<ResultOfGenerateRandomBytes> GenerateRandomBytes(ParamsOfGenerateRandomBytes paramsOfGenerateRandomBytes)
        {
            return await this.Request<ResultOfGenerateRandomBytes>("crypto.generate_random_bytes", paramsOfGenerateRandomBytes);
        }

        /// <summary>
        ///     Converts the public key to ton safe format.
        /// </summary>
        /// <param name="paramsOfConvertPublicKeyToTonSafeFormat">The parameters of convert public key to ton safe format.</param>
        /// <returns></returns>
        public async Task<ResultOfConvertPublicKeyToTonSafeFormat> ConvertPublicKeyToTonSafeFormat(ParamsOfConvertPublicKeyToTonSafeFormat paramsOfConvertPublicKeyToTonSafeFormat)
        {
            return await this.Request<ResultOfConvertPublicKeyToTonSafeFormat>("crypto.convert_public_key_to_ton_safe_format", paramsOfConvertPublicKeyToTonSafeFormat);
        }

        /// <summary>
        ///     Generates the random sign keys.
        /// </summary>
        /// <returns></returns>
        public async Task<KeyPair> GenerateRandomSignKeys()
        {
            return await this.Request<KeyPair>("crypto.generate_random_sign_keys");
        }

        /// <summary>
        ///     Signs the specified parameters of sign.
        /// </summary>
        /// <param name="paramsOfSign">The parameters of sign.</param>
        /// <returns></returns>
        public async Task<ResultOfSign> Sign(ParamsOfSign paramsOfSign)
        {
            return await this.Request<ResultOfSign>("crypto.sign", paramsOfSign);
        }

        /// <summary>
        ///     Verifies the signature.
        /// </summary>
        /// <param name="paramsOfVerifySignature">The parameters of verify signature.</param>
        /// <returns></returns>
        public async Task<ResultOfVerifySignature> VerifySignature(ParamsOfVerifySignature paramsOfVerifySignature)
        {
            return await this.Request<ResultOfVerifySignature>("crypto.verify_signature", paramsOfVerifySignature);
        }

        /// <summary>
        ///     Sha256s the specified parameters of hash.
        /// </summary>
        /// <param name="paramsOfHash">The parameters of hash.</param>
        /// <returns></returns>
        public async Task<ResultOfHash> Sha256(ParamsOfHash paramsOfHash)
        {
            return await this.Request<ResultOfHash>("crypto.sha256", paramsOfHash);
        }

        /// <summary>
        ///     Sha512s the specified parameters of hash.
        /// </summary>
        /// <param name="paramsOfHash">The parameters of hash.</param>
        /// <returns></returns>
        public async Task<ResultOfHash> Sha512(ParamsOfHash paramsOfHash)
        {
            return await this.Request<ResultOfHash>("crypto.sha512", paramsOfHash);
        }

        /// <summary>
        ///     Scrypts the specified parameters of scrypt.
        /// </summary>
        /// <param name="paramsOfScrypt">The parameters of scrypt.</param>
        /// <returns></returns>
        public async Task<ResultOfScrypt> Scrypt(ParamsOfScrypt paramsOfScrypt)
        {
            return await this.Request<ResultOfScrypt>("crypto.scrypt", paramsOfScrypt);
        }

        /// <summary>
        ///     Nacls the sign keypair from secret key.
        /// </summary>
        /// <param name="paramsOfNaclSignKeyPairFromSecret">The parameters of nacl sign key pair from secret.</param>
        /// <returns></returns>
        public async Task<KeyPair> NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret paramsOfNaclSignKeyPairFromSecret)
        {
            return await this.Request<KeyPair>("crypto.nacl_sign_keypair_from_secret_key", paramsOfNaclSignKeyPairFromSecret);
        }

        /// <summary>
        ///     Nacls the sign.
        /// </summary>
        /// <param name="paramsOfNaclSignOpen">The parameters of nacl sign open.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclSignOpen> NaclSignOpen(ParamsOfNaclSignOpen paramsOfNaclSignOpen)
        {
            return await this.Request<ResultOfNaclSignOpen>("crypto.nacl_sign_open", paramsOfNaclSignOpen);
        }

        /// <summary>
        ///     Nacls the sign detached.
        /// </summary>
        /// <param name="paramsOfNaclSign">The parameters of nacl sign.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclSignDetached> NaclSignDetached(ParamsOfNaclSign paramsOfNaclSign)
        {
            return await this.Request<ResultOfNaclSignDetached>("crypto.nacl_sign_detached", paramsOfNaclSign);
        }

        /// <summary>
        ///     Nacls the box keypair.
        /// </summary>
        /// <returns></returns>
        public async Task<KeyPair> NaclBoxKeypair()
        {
            return await this.Request<KeyPair>("crypto.nacl_box_keypair");
        }

        /// <summary>
        ///     Nacls the box key pair from secret key.
        /// </summary>
        /// <param name="paramsOfNaclBoxKeyPairFromSecret">The parameters of nacl box key pair from secret.</param>
        /// <returns></returns>
        public async Task<KeyPair> NaclBoxKeyPairFromSecretKey(ParamsOfNaclBoxKeyPairFromSecret paramsOfNaclBoxKeyPairFromSecret)
        {
            return await this.Request<KeyPair>("crypto.nacl_box_keypair_from_secret_key", paramsOfNaclBoxKeyPairFromSecret);
        }

        /// <summary>
        ///     Nacls the box.
        /// </summary>
        /// <param name="paramsOfNaclBox">The parameters of nacl box.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclBox> NaclBox(ParamsOfNaclBox paramsOfNaclBox)
        {
            return await this.Request<ResultOfNaclBox>("crypto.nacl_box", paramsOfNaclBox);
        }

        /// <summary>
        ///     Nacls the box open.
        /// </summary>
        /// <param name="paramsOfNaclBoxOpen">The parameters of nacl box open.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclBoxOpen> NaclBoxOpen(ParamsOfNaclBoxOpen paramsOfNaclBoxOpen)
        {
            return await this.Request<ResultOfNaclBoxOpen>("crypto.nacl_box_open", paramsOfNaclBoxOpen);
        }

        /// <summary>
        ///     Nacls the secret box.
        /// </summary>
        /// <param name="paramsOfNaclSecretBox">The parameters of nacl secret box.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclBox> NaclSecretBox(ParamsOfNaclSecretBox paramsOfNaclSecretBox)
        {
            return await this.Request<ResultOfNaclBox>("crypto.nacl_secret_box", paramsOfNaclSecretBox);
        }

        /// <summary>
        ///     Nacls the secret box.
        /// </summary>
        /// <param name="paramsOfNaclSecretBoxOpen">The parameters of nacl secret box open.</param>
        /// <returns></returns>
        public async Task<ResultOfNaclBoxOpen> NaclSecretBoxOpen(ParamsOfNaclSecretBoxOpen paramsOfNaclSecretBoxOpen)
        {
            return await this.Request<ResultOfNaclBoxOpen>("crypto.nacl_secret_box_open", paramsOfNaclSecretBoxOpen);
        }

        /// <summary>
        ///     Mnemonics the words.
        /// </summary>
        /// <param name="paramsOfMnemonicWords">The parameters of mnemonic words.</param>
        /// <returns></returns>
        public async Task<ResultOfMnemonicWords> MnemonicWords(ParamsOfMnemonicWords paramsOfMnemonicWords)
        {
            return await this.Request<ResultOfMnemonicWords>("crypto.mnemonic_words", paramsOfMnemonicWords);
        }

        /// <summary>
        ///     Mnemonics from random.
        /// </summary>
        /// <param name="paramsOfMnemonicFromRandom">The parameters of mnemonic from random.</param>
        /// <returns></returns>
        public async Task<ResultOfMnemonicFromRandom> MnemonicFromRandom(ParamsOfMnemonicFromRandom paramsOfMnemonicFromRandom)
        {
            return await this.Request<ResultOfMnemonicFromRandom>("crypto.mnemonic_from_random", paramsOfMnemonicFromRandom);
        }

        /// <summary>
        ///     Mnemonics from entropy.
        /// </summary>
        /// <param name="paramsOfMnemonicFromEntropy">The parameters of mnemonic from entropy.</param>
        /// <returns></returns>
        public async Task<ResultOfMnemonicFromEntropy> MnemonicFromEntropy(ParamsOfMnemonicFromEntropy paramsOfMnemonicFromEntropy)
        {
            return await this.Request<ResultOfMnemonicFromEntropy>("crypto.mnemonic_from_entropy", paramsOfMnemonicFromEntropy);
        }

        /// <summary>
        ///     Mnemonics the verify.
        /// </summary>
        /// <param name="paramsOfMnemonicVerify">The parameters of mnemonic verify.</param>
        /// <returns></returns>
        public async Task<ResultOfMnemonicFromEntropy> MnemonicVerify(ParamsOfMnemonicVerify paramsOfMnemonicVerify)
        {
            return await this.Request<ResultOfMnemonicFromEntropy>("crypto.mnemonic_verify", paramsOfMnemonicVerify);
        }

        /// <summary>
        ///     Mnemonics the derive sign keys.
        /// </summary>
        /// <param name="paramsOfMnemonicDeriveSignKeys">The parameters of mnemonic derive sign keys.</param>
        /// <returns></returns>
        public async Task<KeyPair> MnemonicDeriveSignKeys(ParamsOfMnemonicDeriveSignKeys paramsOfMnemonicDeriveSignKeys)
        {
            return await this.Request<KeyPair>("crypto.mnemonic_derive_sign_keys", paramsOfMnemonicDeriveSignKeys);
        }

        /// <summary>
        ///     Hdkeys the XPRV from mnemonic.
        /// </summary>
        /// <param name="paramsOfHDKeyXPrvFromMnemonic">The parameters of hd key x PRV from mnemonic.</param>
        /// <returns></returns>
        public async Task<ResultOfHDKeyXPrvFromMnemonic> HDKeyXprvFromMnemonic(ParamsOfHDKeyXPrvFromMnemonic paramsOfHDKeyXPrvFromMnemonic)
        {
            return await this.Request<ResultOfHDKeyXPrvFromMnemonic>("crypto.hdkey_xprv_from_mnemonic", paramsOfHDKeyXPrvFromMnemonic);
        }

        /// <summary>
        ///     Hdkeys the derive from XPRV.
        /// </summary>
        /// <param name="paramsOfHDKeyDeriveFromXPrv">The parameters of hd key derive from x PRV.</param>
        /// <returns></returns>
        public async Task<ResultOfHDKeyDeriveFromXPrv> HDKeyDeriveFromXprv(ParamsOfHDKeyDeriveFromXPrv paramsOfHDKeyDeriveFromXPrv)
        {
            return await this.Request<ResultOfHDKeyDeriveFromXPrv>("crypto.hdkey_derive_from_xprv", paramsOfHDKeyDeriveFromXPrv);
        }

        /// <summary>
        ///     Hds the key derive from XPRV path.
        /// </summary>
        /// <param name="paramsOfHDKeyDeriveFromXPrvPath">The parameters of hd key derive from x PRV path.</param>
        /// <returns></returns>
        public async Task<ResultOfHDKeyDeriveFromXPrvPath> HDKey_derive_from_xprv_path(ParamsOfHDKeyDeriveFromXPrvPath paramsOfHDKeyDeriveFromXPrvPath)
        {
            return await this.Request<ResultOfHDKeyDeriveFromXPrvPath>("crypto.hdkey_derive_from_xprv_path", paramsOfHDKeyDeriveFromXPrvPath);
        }

        /// <summary>
        ///     Hds the key secret from XPRV.
        /// </summary>
        /// <param name="paramsOfHDKeySecretFromXPrv">The parameters of hd key secret from x PRV.</param>
        /// <returns></returns>
        public async Task<ResultOfHDKeySecretFromXPrv> HDKeySecretFromXprv(ParamsOfHDKeySecretFromXPrv paramsOfHDKeySecretFromXPrv)
        {
            return await this.Request<ResultOfHDKeySecretFromXPrv>("crypto.hdkey_secret_from_xprv", paramsOfHDKeySecretFromXPrv);
        }

        /// <summary>
        ///     Hds the key public from XPRV.
        /// </summary>
        /// <param name="paramsOfHDKeyPublicFromXPrv">The parameters of hd key public from x PRV.</param>
        /// <returns></returns>
        public async Task<ResultOfHDKeyPublicFromXPrv> HDKeyPublicFromXprv(ParamsOfHDKeyPublicFromXPrv paramsOfHDKeyPublicFromXPrv)
        {
            return await this.Request<ResultOfHDKeyPublicFromXPrv>("crypto.hdkey_public_from_xprv", paramsOfHDKeyPublicFromXPrv);
        }

        #endregion
    }
}