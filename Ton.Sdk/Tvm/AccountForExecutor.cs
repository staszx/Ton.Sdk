namespace Ton.Sdk.Tvm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     The account for executor
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_tvm.md#AccountForExecutor
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class AccountForExecutor
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AccountForExecutor" /> class.
        /// </summary>
        public AccountForExecutor()
        {
            this.Type = AccountForExecutorType.None;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AccountForExecutor" /> class.
        /// </summary>
        /// <param name="boc">The boc.</param>
        /// <param name="unlimitedBalance">The unlimited balance.</param>
        public AccountForExecutor(string boc, bool? unlimitedBalance = null)
        {
            this.Type = AccountForExecutorType.Account;
            this.Boc = boc;
            this.UnlimitedBalance = unlimitedBalance;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountForExecutorType Type { get; private set; }

        /// <summary>
        ///     Gets or sets the boc.
        /// </summary>
        /// <value>
        ///     The boc.
        /// </value>
        [JsonProperty("boc")]
        public string Boc { get; private set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [unlimited balance].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [unlimited balance]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("unlimited_balance")]
        public bool? UnlimitedBalance { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Gets the none.
        /// </summary>
        /// <returns></returns>
        public static AccountForExecutor GetNone()
        {
            return new AccountForExecutor();
        }

        /// <summary>
        ///     Gets the uninit.
        /// </summary>
        /// <returns></returns>
        public static AccountForExecutor GetUninit()
        {
            var accountForExecutor = new AccountForExecutor();
            accountForExecutor.Type = AccountForExecutorType.Uninit;
            return accountForExecutor;
        }

        /// <summary>
        ///     Gets the account.
        /// </summary>
        /// <param name="boc">The boc.</param>
        /// <param name="unlimitedBalance">if set to <c>true</c> [unlimited balance].</param>
        /// <returns></returns>
        public static AccountForExecutor GetAccount(string boc, bool unlimitedBalance)
        {
            return new AccountForExecutor(boc, unlimitedBalance);
        }

        #endregion
    }
}