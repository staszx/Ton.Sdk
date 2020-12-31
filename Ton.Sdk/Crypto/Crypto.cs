namespace Ton.Sdk.Crypto
{
    using System.Threading.Tasks;
    using Request;

    /// <summary>
    ///     The Crypto module
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Crypto : TonClientModule

    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Crypto" /> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        internal Crypto(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Factorizes the specified parameters of factorize.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#factorize
        /// </summary>
        /// <param name="paramsOfFactorize">The parameters of factorize.</param>
        /// <returns></returns>
        public async Task<ResultOfFactorize> Factorize(ParamsOfFactorize paramsOfFactorize)
        {
            return await this.Request<ResultOfFactorize>("crypto.factorize", paramsOfFactorize);
        }

        /// <summary>
        ///     Modulars the power.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#modular_power
        /// </summary>
        /// <param name="paramsOfModularPower">The parameters of modular power.</param>
        /// <returns>ResultOfModularPower</returns>
        public async Task<ResultOfModularPower> ModularPower(ParamsOfModularPower paramsOfModularPower)
        {
            return await this.Request<ResultOfModularPower>("crypto.modular_power", paramsOfModularPower);
        }

        /// <summary>
        ///     The Crc16
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#ton_crc16
        /// </summary>
        /// <param name="paramsOfTonCrc16">The parameters of ton CRC16.</param>
        /// <returns>ResultOfTonCrc16</returns>
        public async Task<ResultOfTonCrc16> Crc16(ParamsOfTonCrc16 paramsOfTonCrc16)
        {
            return await this.Request<ResultOfTonCrc16>("crypto.ton_crc16", paramsOfTonCrc16);
        }

        /// <summary>
        ///     Generates the random bytes.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#generate_random_bytes
        /// </summary>
        /// <param name="paramsOfGenerateRandomBytes">The parameters of generate random bytes.</param>
        /// <returns>ResultOfGenerateRandomBytes</returns>
        public async Task<ResultOfGenerateRandomBytes> GenerateRandomBytes(ParamsOfGenerateRandomBytes paramsOfGenerateRandomBytes)
        {
            return await this.Request<ResultOfGenerateRandomBytes>("crypto.generate_random_bytes", paramsOfGenerateRandomBytes);
        }

        /// <summary>
        ///     Converts the public key to ton safe format.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#convert_public_key_to_ton_safe_format
        /// </summary>
        /// <param name="paramsOfConvertPublicKeyToTonSafeFormat">The parameters of convert public key to ton safe format.</param>
        /// <returns>ResultOfConvertPublicKeyToTonSafeFormat</returns>
        public async Task<ResultOfConvertPublicKeyToTonSafeFormat> ConvertPublicKeyToTonSafeFormat(
            ParamsOfConvertPublicKeyToTonSafeFormat paramsOfConvertPublicKeyToTonSafeFormat)
        {
            return await this.Request<ResultOfConvertPublicKeyToTonSafeFormat>("crypto.convert_public_key_to_ton_safe_format",
                paramsOfConvertPublicKeyToTonSafeFormat);
        }

        /// <summary>
        ///     Generates the random sign keys.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#generate_random_sign_keys
        /// </summary>
        /// <returns>KeyPair</returns>
        public async Task<KeyPair> GenerateRandomSignKeys()
        {
            return await this.Request<KeyPair>("crypto.generate_random_sign_keys");
        }

        /// <summary>
        ///     Signs the specified parameters of sign.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#sign
        /// </summary>
        /// <param name="paramsOfSign">The parameters of sign.</param>
        /// <returns>ResultOfSign</returns>
        public async Task<ResultOfSign> Sign(ParamsOfSign paramsOfSign)
        {
            return await this.Request<ResultOfSign>("crypto.sign", paramsOfSign);
        }

        /// <summary>
        ///     Verifies the signature.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#verify_signature
        /// </summary>
        /// <param name="paramsOfVerifySignature">The parameters of verify signature.</param>
        /// <returns>ResultOfVerifySignature</returns>
        public async Task<ResultOfVerifySignature> VerifySignature(ParamsOfVerifySignature paramsOfVerifySignature)
        {
            return await this.Request<ResultOfVerifySignature>("crypto.verify_signature", paramsOfVerifySignature);
        }

        /// <summary>
        ///     Sha256s the specified parameters of hash.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#sha256
        /// </summary>
        /// <param name="paramsOfHash">The parameters of hash.</param>
        /// <returns>ResultOfHash</returns>
        public async Task<ResultOfHash> Sha256(ParamsOfHash paramsOfHash)
        {
            return await this.Request<ResultOfHash>("crypto.sha256", paramsOfHash);
        }

        /// <summary>
        ///     Sha512s the specified parameters of hash.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#sha512
        /// </summary>
        /// <param name="paramsOfHash">The parameters of hash.</param>
        /// <returns>ResultOfHash</returns>
        public async Task<ResultOfHash> Sha512(ParamsOfHash paramsOfHash)
        {
            return await this.Request<ResultOfHash>("crypto.sha512", paramsOfHash);
        }

        /// <summary>
        ///     Scrypts the specified parameters of scrypt.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#scrypt
        /// </summary>
        /// <param name="paramsOfScrypt">The parameters of scrypt.</param>
        /// <returns>ResultOfScrypt</returns>
        public async Task<ResultOfScrypt> Scrypt(ParamsOfScrypt paramsOfScrypt)
        {
            return await this.Request<ResultOfScrypt>("crypto.scrypt", paramsOfScrypt);
        }

        /// <summary>
        ///     Nacls the sign.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_sign
        /// </summary>
        /// <param name="paramsOfNaclSign">The parameters of nacl sign.</param>
        /// <returns>ResultOfNaclSign</returns>
        public async Task<ResultOfNaclSign> NaclSign(ParamsOfNaclSign paramsOfNaclSign)
        {
            return await this.Request<ResultOfNaclSign>("crypto.nacl_sign", paramsOfNaclSign);
        }

        /// <summary>
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_sign_keypair_from_secret_key
        ///     Nacls the sign keypair from secret key.
        /// </summary>
        /// <param name="paramsOfNaclSignKeyPairFromSecret">The parameters of nacl sign key pair from secret.</param>
        /// <returns>KeyPair</returns>
        public async Task<KeyPair> NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret paramsOfNaclSignKeyPairFromSecret)
        {
            return await this.Request<KeyPair>("crypto.nacl_sign_keypair_from_secret_key", paramsOfNaclSignKeyPairFromSecret);
        }

        /// <summary>
        ///     Nacls the sign open.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_sign_open
        /// </summary>
        /// <param name="paramsOfNaclSignOpen">The parameters of nacl sign open.</param>
        /// <returns>ResultOfNaclSignOpen</returns>
        public async Task<ResultOfNaclSignOpen> NaclSignOpen(ParamsOfNaclSignOpen paramsOfNaclSignOpen)
        {
            return await this.Request<ResultOfNaclSignOpen>("crypto.nacl_sign_open", paramsOfNaclSignOpen);
        }

        /// <summary>
        ///     Nacls the sign detached.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_sign_detached
        /// </summary>
        /// <param name="paramsOfNaclSign">The parameters of nacl sign.</param>
        /// <returns>ResultOfNaclSignDetached</returns>
        public async Task<ResultOfNaclSignDetached> NaclSignDetached(ParamsOfNaclSign paramsOfNaclSign)
        {
            return await this.Request<ResultOfNaclSignDetached>("crypto.nacl_sign_detached", paramsOfNaclSign);
        }

        /// <summary>
        ///     Nacls the box keypair.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_box_keypair
        /// </summary>
        /// <returns>KeyPair</returns>
        public async Task<KeyPair> NaclBoxKeypair()
        {
            return await this.Request<KeyPair>("crypto.nacl_box_keypair");
        }

        /// <summary>
        ///     Nacls the box key pair from secret key.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_box_keypair_from_secret_key
        /// </summary>
        /// <param name="paramsOfNaclBoxKeyPairFromSecret">The parameters of nacl box key pair from secret.</param>
        /// <returns>KeyPair</returns>
        public async Task<KeyPair> NaclBoxKeyPairFromSecretKey(ParamsOfNaclBoxKeyPairFromSecret paramsOfNaclBoxKeyPairFromSecret)
        {
            return await this.Request<KeyPair>("crypto.nacl_box_keypair_from_secret_key", paramsOfNaclBoxKeyPairFromSecret);
        }

        /// <summary>
        ///     Nacls the box.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_box
        /// </summary>
        /// <param name="paramsOfNaclBox">The parameters of nacl box.</param>
        /// <returns>ResultOfNaclBox</returns>
        public async Task<ResultOfNaclBox> NaclBox(ParamsOfNaclBox paramsOfNaclBox)
        {
            return await this.Request<ResultOfNaclBox>("crypto.nacl_box", paramsOfNaclBox);
        }

        /// <summary>
        ///     Nacls the box open.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_box_open
        /// </summary>
        /// <param name="paramsOfNaclBoxOpen">The parameters of nacl box open.</param>
        /// <returns>ResultOfNaclBoxOpen</returns>
        public async Task<ResultOfNaclBoxOpen> NaclBoxOpen(ParamsOfNaclBoxOpen paramsOfNaclBoxOpen)
        {
            return await this.Request<ResultOfNaclBoxOpen>("crypto.nacl_box_open", paramsOfNaclBoxOpen);
        }

        /// <summary>
        ///     Nacls the secret box.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_secret_box
        /// </summary>
        /// <param name="paramsOfNaclSecretBox">The parameters of nacl secret box.</param>
        /// <returns>ResultOfNaclBox</returns>
        public async Task<ResultOfNaclBox> NaclSecretBox(ParamsOfNaclSecretBox paramsOfNaclSecretBox)
        {
            return await this.Request<ResultOfNaclBox>("crypto.nacl_secret_box", paramsOfNaclSecretBox);
        }

        /// <summary>
        ///     Nacls the secret box open
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#nacl_secret_box_open
        /// </summary>
        /// <param name="paramsOfNaclSecretBoxOpen">The parameters of nacl secret box open.</param>
        /// <returns>ResultOfNaclBoxOpen</returns>
        public async Task<ResultOfNaclBoxOpen> NaclSecretBoxOpen(ParamsOfNaclSecretBoxOpen paramsOfNaclSecretBoxOpen)
        {
            return await this.Request<ResultOfNaclBoxOpen>("crypto.nacl_secret_box_open", paramsOfNaclSecretBoxOpen);
        }

        /// <summary>
        ///     Mnemonics the words.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#mnemonic_words
        /// </summary>
        /// <param name="paramsOfMnemonicWords">The parameters of mnemonic words.</param>
        /// <returns>ResultOfMnemonicWords</returns>
        public async Task<ResultOfMnemonicWords> MnemonicWords(ParamsOfMnemonicWords paramsOfMnemonicWords)
        {
            return await this.Request<ResultOfMnemonicWords>("crypto.mnemonic_words", paramsOfMnemonicWords);
        }

        /// <summary>
        ///     Mnemonics from random.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#mnemonic_from_random
        /// </summary>
        /// <param name="paramsOfMnemonicFromRandom">The parameters of mnemonic from random.</param>
        /// <returns>ResultOfMnemonicFromRandom</returns>
        public async Task<ResultOfMnemonicFromRandom> MnemonicFromRandom(ParamsOfMnemonicFromRandom paramsOfMnemonicFromRandom)
        {
            return await this.Request<ResultOfMnemonicFromRandom>("crypto.mnemonic_from_random", paramsOfMnemonicFromRandom);
        }

        /// <summary>
        ///     Mnemonics from entropy.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#mnemonic_from_entropy
        /// </summary>
        /// <param name="paramsOfMnemonicFromEntropy">The parameters of mnemonic from entropy.</param>
        /// <returns>ResultOfMnemonicFromEntropy</returns>
        public async Task<ResultOfMnemonicFromEntropy> MnemonicFromEntropy(ParamsOfMnemonicFromEntropy paramsOfMnemonicFromEntropy)
        {
            return await this.Request<ResultOfMnemonicFromEntropy>("crypto.mnemonic_from_entropy", paramsOfMnemonicFromEntropy);
        }

        /// <summary>
        ///     Mnemonics the verify.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#mnemonic_verify
        /// </summary>
        /// <param name="paramsOfMnemonicVerify">The parameters of mnemonic verify.</param>
        /// <returns>ResultOfMnemonicVerify</returns>
        public async Task<ResultOfMnemonicVerify> MnemonicVerify(ParamsOfMnemonicVerify paramsOfMnemonicVerify)
        {
            return await this.Request<ResultOfMnemonicVerify>("crypto.mnemonic_verify", paramsOfMnemonicVerify);
        }

        /// <summary>
        ///     Mnemonics the derive sign keys.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#mnemonic_derive_sign_keys
        /// </summary>
        /// <param name="paramsOfMnemonicDeriveSignKeys">The parameters of mnemonic derive sign keys.</param>
        /// <returns>KeyPair</returns>
        public async Task<KeyPair> MnemonicDeriveSignKeys(ParamsOfMnemonicDeriveSignKeys paramsOfMnemonicDeriveSignKeys)
        {
            return await this.Request<KeyPair>("crypto.mnemonic_derive_sign_keys", paramsOfMnemonicDeriveSignKeys);
        }

        /// <summary>
        ///     Hdkeys the XPRV from mnemonic.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#hdkey_xprv_from_mnemonic
        /// </summary>
        /// <param name="paramsOfHDKeyXPrvFromMnemonic">The parameters of hd key x PRV from mnemonic.</param>
        /// <returns>ResultOfHDKeyXPrvFromMnemonic</returns>
        public async Task<ResultOfHDKeyXPrvFromMnemonic> HDKeyXprvFromMnemonic(ParamsOfHDKeyXPrvFromMnemonic paramsOfHDKeyXPrvFromMnemonic)
        {
            return await this.Request<ResultOfHDKeyXPrvFromMnemonic>("crypto.hdkey_xprv_from_mnemonic", paramsOfHDKeyXPrvFromMnemonic);
        }

        /// <summary>
        ///     Hdkeys the derive from XPRV.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#hdkey_derive_from_xprv
        /// </summary>
        /// <param name="paramsOfHDKeyDeriveFromXPrv">The parameters of hd key derive from x PRV.</param>
        /// <returns>ResultOfHDKeyDeriveFromXPrv</returns>
        public async Task<ResultOfHDKeyDeriveFromXPrv> HDKeyDeriveFromXprv(ParamsOfHDKeyDeriveFromXPrv paramsOfHDKeyDeriveFromXPrv)
        {
            return await this.Request<ResultOfHDKeyDeriveFromXPrv>("crypto.hdkey_derive_from_xprv", paramsOfHDKeyDeriveFromXPrv);
        }

        /// <summary>
        ///     Hds the key derive from XPRV path.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#hdkey_derive_from_xprv_path
        /// </summary>
        /// <param name="paramsOfHDKeyDeriveFromXPrvPath">The parameters of hd key derive from x PRV path.</param>
        /// <returns>ResultOfHDKeyDeriveFromXPrvPath</returns>
        public async Task<ResultOfHDKeyDeriveFromXPrvPath> HDKeyDeriveFromXprvPath(ParamsOfHDKeyDeriveFromXPrvPath paramsOfHDKeyDeriveFromXPrvPath)
        {
            return await this.Request<ResultOfHDKeyDeriveFromXPrvPath>("crypto.hdkey_derive_from_xprv_path", paramsOfHDKeyDeriveFromXPrvPath);
        }

        /// <summary>
        ///     Hds the key secret from XPRV.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#hdkey_secret_from_xprv
        /// </summary>
        /// <param name="paramsOfHDKeySecretFromXPrv">The parameters of hd key secret from x PRV.</param>
        /// <returns>ResultOfHDKeySecretFromXPrv</returns>
        public async Task<ResultOfHDKeySecretFromXPrv> HDKeySecretFromXprv(ParamsOfHDKeySecretFromXPrv paramsOfHDKeySecretFromXPrv)
        {
            return await this.Request<ResultOfHDKeySecretFromXPrv>("crypto.hdkey_secret_from_xprv", paramsOfHDKeySecretFromXPrv);
        }

        /// <summary>
        ///     Hds the key public from XPRV.
        ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#hdkey_public_from_xprv
        /// </summary>
        /// <param name="paramsOfHDKeyPublicFromXPrv">The parameters of hd key public from x PRV.</param>
        /// <returns>ResultOfHDKeyPublicFromXPrv</returns>
        public async Task<ResultOfHDKeyPublicFromXPrv> HDKeyPublicFromXprv(ParamsOfHDKeyPublicFromXPrv paramsOfHDKeyPublicFromXPrv)
        {
            return await this.Request<ResultOfHDKeyPublicFromXPrv>("crypto.hdkey_public_from_xprv", paramsOfHDKeyPublicFromXPrv);
        }

        /// <summary>
        /// Chacha20s the specified parameters of chacha20.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#chacha20
        /// </summary>
        /// <param name="paramsOfChacha20">The parameters of chacha20.</param>
        /// <returns></returns>
        public async Task<ResultOfChacha20> Chacha20(ParamsOfChacha20 paramsOfChacha20)
        {
            return await this.Request<ResultOfChacha20>("crypto.chacha20", paramsOfChacha20);
        }

        /// <summary>
        /// Registers the signing box.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#register_signing_box
        /// </summary>
        /// <returns></returns>
        public async Task<RegisteredSigningBox> RegisterSigningBox(ResponseHandler responseHandler)
        {
            return await this.Request<RegisteredSigningBox>("crypto.register_signing_box", null, responseHandler);
        }

        /// <summary>
        /// Gets the signed box.
        /// </summary>
        /// <param name="keyPair">The key pair.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#get_signing_box
        /// <returns></returns>
        public async Task<RegisteredSigningBox> GetSignedBox(KeyPair keyPair)
        {
            return await this.Request<RegisteredSigningBox>("crypto.get_signing_box", keyPair);
        }

        /// <summary>
        /// Signings the box get public key.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#signing_box_get_public_key
        /// </summary>
        /// <param name="registeredSigningBox">The registered signing box.</param>
        /// <returns></returns>
        public async Task<ResultOfSigningBoxGetPublicKey> SigningBoxGetPublicKey(RegisteredSigningBox registeredSigningBox)
        {
            return await this.Request<ResultOfSigningBoxGetPublicKey>("crypto.signing_box_get_public_key", registeredSigningBox);
        }

        /// <summary>
        /// Signings the box sign.
        /// </summary>
        /// <param name="paramsOfSigningBoxSign">The parameters of signing box sign.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#signing_box_sign
        /// <returns></returns>
        public async Task<ResultOfSigningBoxSign> SigningBoxSign(ParamsOfSigningBoxSign paramsOfSigningBoxSign)
        {
            return await this.Request<ResultOfSigningBoxSign>("crypto.signing_box_sign", paramsOfSigningBoxSign);
        }

        /// <summary>
        /// Removes the signing box.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_crypto.md#remove_signing_box
        /// </summary>
        /// <param name="registeredSigningBox">The registered signing box.</param>
        public async Task RemoveSigningBox(RegisteredSigningBox registeredSigningBox)
        {
             await this.Request<object>("crypto.remove_signing_box", registeredSigningBox);
        }
        #endregion
    }
}