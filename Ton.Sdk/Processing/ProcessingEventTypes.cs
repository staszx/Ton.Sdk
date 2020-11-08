namespace Ton.Sdk.Processing
{
    /// <summary>
    ///     The processing event types
    /// </summary>
    public enum ProcessingEventTypes
    {
        /// <summary>
        ///     The will fetch first block
        /// </summary>
        WillFetchFirstBlock,

        /// <summary>
        ///     The fetch first block failed
        /// </summary>
        FetchFirstBlockFailed,

        /// <summary>
        ///     The will send
        /// </summary>
        WillSend,

        /// <summary>
        ///     The did send
        /// </summary>
        DidSend,

        /// <summary>
        ///     The send failed
        /// </summary>
        SendFailed,

        /// <summary>
        ///     The will fetch next block
        /// </summary>
        WillFetchNextBlock,

        /// <summary>
        ///     The fetch next block failed
        /// </summary>
        FetchNextBlockFailed,

        /// <summary>
        ///     The message expired
        /// </summary>
        MessageExpired
    }
}