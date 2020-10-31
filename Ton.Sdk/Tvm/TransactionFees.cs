namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;

    public class TransactionFees
    {
        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="TransactionFees" /> is aborted.
        /// </summary>
        /// <value>
        ///     <c>true</c> if aborted; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("aborted")]
        private bool Aborted { get; set; }

        #endregion
    }
}