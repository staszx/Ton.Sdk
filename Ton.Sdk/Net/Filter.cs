namespace Ton.Sdk.Net
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    ///     The filter
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.Linq.JRaw" />
    public class Filter : JRaw
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="other">A <see cref="T:Newtonsoft.Json.Linq.JRaw" /> object to copy from.</param>
        public Filter(JRaw other) : base(other)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="rawJson">The raw json.</param>
        public Filter(object? rawJson) : base(rawJson)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Filter" /> class.
        ///     Build simple filter
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="type">The type.</param>
        /// <param name="value">The value.</param>
        public Filter(string field, string type, object value) : this(BuildFilter(field, type, value.ToString()))
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Builds the filter.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="type">The type.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private static string BuildFilter(string field, string type, string value)
        {
            return "{\"" + field + "\":{\"" + type + "\":" + value + "}}";
        }

        #endregion
    }
}