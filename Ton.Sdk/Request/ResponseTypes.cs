namespace Ton.Sdk.Request
{
    /// <summary>
    ///     The response types
    /// </summary>
    public enum ResponseTypes : uint
    {
        /// <summary>
        ///     The  response success
        /// </summary>
        Success = 0,

        /// <summary>
        ///     The  response error
        /// </summary>
        Error = 1,

        /// <summary>
        ///     The  response nop
        /// </summary>
        Nop = 2,

        /// <summary>
        ///     The  response custom
        /// </summary>
        Custom = 100
    }
}