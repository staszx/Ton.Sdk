namespace Ton.Sdk.Tests
{
    using System.Threading.Tasks;
    using Client;
    using NUnit.Framework;
    using Utils;

    /// <summary>
    /// The utils module tests
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class UtilsTest : TonClientTestCommon
    {
        #region Methods

        /// <summary>
        ///     Converts the adress test.
        /// </summary>
        [Test]
        public async Task ConvertAdressTest()
        {
            var accountId = "fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
            var hex = "-1:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
            var hexWorkchain0 = "0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
            var base64 = "Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9";
            var base64Url = "kf_8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15-KsQHFLbKSMiYIny";
            using var client = new TonClient(new ClientConfig());
            var paramsOfConvertAddress = new ParamsOfConvertAddress();
            paramsOfConvertAddress.Address = accountId;
            paramsOfConvertAddress.OutputFormat = new AddressStringFormat
            {
                Type = AddressStringFormatType.Hex
            };
            var converted = await client.Utils.ConvertAddress(paramsOfConvertAddress);
            this.Check(hexWorkchain0, converted.Address, "Hex");

            paramsOfConvertAddress.Address = converted.Address;
            paramsOfConvertAddress.OutputFormat.Type = AddressStringFormatType.AccountId;
            converted = await client.Utils.ConvertAddress(paramsOfConvertAddress);
            this.Check(accountId, converted.Address, "AccountId");

            paramsOfConvertAddress.Address = hex;
            paramsOfConvertAddress.OutputFormat.Type = AddressStringFormatType.Base64;
            converted = await client.Utils.ConvertAddress(paramsOfConvertAddress);
            this.Check(base64, converted.Address, "Base64");

            paramsOfConvertAddress.Address = base64;
            paramsOfConvertAddress.OutputFormat.Type = AddressStringFormatType.Base64;
            paramsOfConvertAddress.OutputFormat.Bounce = true;
            paramsOfConvertAddress.OutputFormat.Test = true;
            paramsOfConvertAddress.OutputFormat.Url = true;
            converted = await client.Utils.ConvertAddress(paramsOfConvertAddress);
            this.Check(base64Url, converted.Address, "Base64Url");

            paramsOfConvertAddress.Address = base64Url;
            paramsOfConvertAddress.OutputFormat.Type = AddressStringFormatType.Hex;
            converted = await client.Utils.ConvertAddress(paramsOfConvertAddress);
            this.Check(hex, converted.Address, "Hex2");
        }

        /// <summary>
        ///     Utilses the exception tests.
        /// </summary>
        [Test]
        public async Task UtilsExceptionTests()
        {
            await this.CheckException(ExceptionConvertAddressTest);
        }

        /// <summary>
        ///     Exceptions the convert address test.
        /// </summary>
        private static async Task ExceptionConvertAddressTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Utils.ConvertAddress(new ParamsOfConvertAddress
            {
                Address = "-1:00",
                OutputFormat = new AddressStringFormat
                {
                    Type = AddressStringFormatType.Hex
                }
            });
        }

        #endregion
    }
}