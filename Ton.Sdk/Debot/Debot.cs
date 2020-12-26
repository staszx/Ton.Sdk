namespace Ton.Sdk.Debot
{
    /// <summary>
    /// The debot module
    /// </summary>
    /// <seealso cref="Ton.Sdk.TonClientModule" />
    public class Debot : TonClientModule
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Debot"/> class.
        /// </summary>
        /// <param name="tonClient">The ton client.</param>
        public Debot(TonClient tonClient) : base(tonClient)
        {
        }

        #endregion
    }
}