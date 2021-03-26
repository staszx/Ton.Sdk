namespace Ton.Sdk.Utils
{
    using System.Threading.Tasks;

    /// <summary>
    ///     The utils
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Utils : TonClientModule
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Utils" /> class.
        /// </summary>
        /// <param name="tonClient">The request library.</param>
        internal Utils(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Converts the adress.
        /// </summary>
        /// <param name="paramsOfConvertAddress">The parameters of convert address.</param>
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md#convert_address
        /// <returns>ResultOfConvertAddress</returns>
        public async Task<ResultOfConvertAddress> ConvertAddress(ParamsOfConvertAddress paramsOfConvertAddress)
        {
            return await this.Request<ResultOfConvertAddress>("utils.convert_address", paramsOfConvertAddress);
        }

        /// <summary>
        /// Calculates the storage fee.
        /// https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_utils.md#calc_storage_fee
        /// </summary>
        /// <param name="paramsOfCalcStorageFee">The parameters of calculate storage fee.</param>
        /// <returns></returns>
        public async Task<ResultOfCalcStorageFee> CalcStorageFee(ParamsOfCalcStorageFee paramsOfCalcStorageFee)
        {
            return await this.Request<ResultOfCalcStorageFee>("utils.calc_storage_fee", paramsOfCalcStorageFee);
        }

        #endregion
    }
}