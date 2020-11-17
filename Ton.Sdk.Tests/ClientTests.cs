namespace Ton.Sdk.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Client;
    using External;
    using Net;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using Request;

    /// <summary>
    ///     The client module tests
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class ClientTests : TonClientTestCommon
    {
        #region Methods

        /// <summary>
        ///     Creates the context test.
        /// </summary>
        [Test]
        public void CreateContextTest()
        {
            var text = "{\"{}\", 2 }";
            var config = new tc_string_data_t
            {
                Value = text
            };
            var jsonPtr = Lib.tc_create_context(config);
            var json = Lib.tc_read_string(jsonPtr);
            Console.WriteLine(json);
        }

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

        /// <summary>
        ///     Gets the build information test.
        /// </summary>
        [Test, Ignore("not work in v1.1.1")]
        public async Task GetBuildInfoTest()
        {
            var expectedBuildNumber = 788;
            using var client = new TonClient(new ClientConfig());
            var result = await client.Client.BuildInfo();
            var buildNumber = result.BuildInfo["buildNumber"].Value<int>();
            Assert.AreEqual(expectedBuildNumber, buildNumber);
        }

        /// <summary>
        /// Multithreadings the test.
        /// </summary>
        [Test]
        public void MultithreadingTest()
        {
            using var client = new TonClient(this.ClientConfig);
            var param = new ParamsOfQueryCollection
            {
                Collection = "messages",
                Result = "id",
                Limit = 1
            };

            List<Task> tasks = new List<Task>();
            int threads = Process.GetCurrentProcess().Threads.Count;
            int maxThreads = 0;
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(client.Net.QueryCollection(param));
                int count = Process.GetCurrentProcess().Threads.Count;
                if ( count > maxThreads)
                {
                    maxThreads = count;
                }
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(threads);
            Console.WriteLine(maxThreads);
            Assert.Greater(maxThreads, threads);
        }

        #endregion
    }
}