namespace Ton.Sdk.Exceptions
{
    using System;

    /// <summary>
    /// The Ton client internal exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    internal class TonClientInternalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TonClientInternalException"/> class.
        /// </summary>
        public TonClientInternalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TonClientInternalException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public TonClientInternalException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TonClientInternalException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public TonClientInternalException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}