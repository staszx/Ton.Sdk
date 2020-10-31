
namespace Ton.Sdk.Tests
{
    using System;
    using Client;
    using NUnit.Framework;
    using Utils;

    public class UtilsTest
    {
        //https://github.com/tonlabs/TON-SDK/blob/master/ton_client/client/src/utils/tests.rs
        //let account_id = "fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
        //let hex = "-1:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
        //let hex_workchain0 = "0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260";
        //let base64 = "Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9";
        //let base64url = "kf_8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15-KsQHFLbKSMiYIny";
        [Test]
        public void ConvertAdressTest()
        {
            using TonClient client = new TonClient(new ClientConfig());
            ParamsOfConvertAddress paramsOfConvertAddress = new ParamsOfConvertAddress();
            paramsOfConvertAddress.Address = "Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9";
            paramsOfConvertAddress.OutputFormat = new AddressStringFormat() { Type = AddressStringFormatType.Base64 };
            Console.WriteLine(client.Utils.ConvertAddress(paramsOfConvertAddress).Result.Address);
        }
    }
}
