namespace Ton.Sdk.Processing
{
    /// <summary>
    /// </summary>
    public enum ProcessingEventTypes
    {
        WillFetchFirstBlock,
        FetchFirstBlockFailed,
        WillSend,
        DidSend,
        SendFailed,
        WillFetchNextBlock,
        FetchNextBlockFailed,
        MessageExpired
    }
}