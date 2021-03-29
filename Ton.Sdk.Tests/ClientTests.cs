namespace Ton.Sdk.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Client;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;

    /// <summary>
    ///     The client module tests
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class ClientTests : TonClientTestCommon
    {
        #region Methods

        /// <summary>
        ///     Gets the version test.
        /// </summary>
        [Test]
        public async Task GetVersionTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Client.GetVersion();
            Assert.AreEqual(LibVersion, result.Version);
        }

        /// <summary>
        ///     Gets the API reference test.
        /// </summary>
        [Test]
        public async Task GetApiReferenceTest()
        {
            using var client = new TonClient(new ClientConfig());
            var result = await client.Client.GetApiReference();
            var modules = result.Api["modules"];
            Assert.Greater(modules.Count(), 0);
        }

        #endregion
    }
}