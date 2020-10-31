namespace Ton.Sdk.Exceptions
{
    using System;

    /// <summary>
    ///     The unknown response type exception
    /// </summary>
    public class UnknownResponseTypeException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UnknownResponseTypeException" /> class.
        /// </summary>
        public UnknownResponseTypeException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnknownResponseTypeException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UnknownResponseTypeException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnknownResponseTypeException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public UnknownResponseTypeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}