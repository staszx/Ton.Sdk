namespace Ton.Sdk.Boc
{
    /// <summary>
    ///     Boc error code
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#bocerrorcode
    /// </summary>
    public enum BocErrorCode
    {
        InvalidBoc = 201,
        SerializationError = 202,
        InappropriateBlock = 203,
        MissingSourceBoc = 204
    }
}