namespace Ton.Sdk.Abi
{
    /// <summary>
    ///     The state init source type
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_abi.md#stateinitsource
    /// </summary>
    public enum StateInitSourceType
    {
        /// <summary>
        ///     The message
        /// </summary>
        Message,

        /// <summary>
        ///     The state initialize
        /// </summary>
        StateInit,

        /// <summary>
        ///     The TVC
        /// </summary>
        Tvc
    }
}