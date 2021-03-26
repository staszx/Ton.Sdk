namespace Ton.Sdk.Boc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     https://github.com/tonlabs/TON-SDK/blob/master/docs/mod_boc.md#builderop
    /// </summary>
    public class BuilderOp
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public BuilderOpType Type { get; private set; }

        /// <summary>
        ///     Gets or sets the size.
        /// </summary>
        /// <value>
        ///     The size.
        /// </value>
        [JsonProperty("size")]
        public int Size { get; private set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [JsonProperty("value")]
        public string Value { get; private set; }

        /// <summary>
        ///     Gets or sets the builder.
        /// </summary>
        /// <value>
        ///     The builder.
        /// </value>
        [JsonProperty("builder")]
        public BuilderOp[] Builder { get; private set; }

        /// <summary>
        ///     Gets or sets the boc.
        /// </summary>
        /// <value>
        ///     The boc.
        /// </value>
        [JsonProperty("boc")]
        public string Boc { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Creates the type of the integer.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static BuilderOp CreateIntegerType(int size, string value)
        {
            return new BuilderOp
            {
                Type = BuilderOpType.Integer,
                Size = size,
                Value = value
            };
        }

        /// <summary>
        ///     Creates the bit string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static BuilderOp CreateBitString(string value)
        {
            return new BuilderOp
            {
                Type = BuilderOpType.BitString,
                Value = value
            };
        }

        /// <summary>
        ///     Creates the cell.
        /// </summary>
        /// <param name="builderOps">The builder ops.</param>
        /// <returns></returns>
        public static BuilderOp CreateCell(BuilderOp[] builderOps)
        {
            return new BuilderOp
            {
                Type = BuilderOpType.Cell,
                Builder = builderOps
            };
        }

        /// <summary>
        ///     Creates the cell boc.
        /// </summary>
        /// <param name="boc">The boc.</param>
        /// <returns></returns>
        public static BuilderOp CreateCellBoc(string boc)
        {
            return new BuilderOp
            {
                Type = BuilderOpType.CellBoc,
                Boc = boc
            };
        }

        #endregion
    }
}