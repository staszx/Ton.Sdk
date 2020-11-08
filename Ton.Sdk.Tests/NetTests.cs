namespace Ton.Sdk.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Net;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;

    /// <summary>
    ///     The Net testing module
    /// </summary>
    /// <seealso cref="Ton.Sdk.Tests.TonClientTestCommon" />
    public class NetTests : TonClientTestCommon
    {
        #region Methods

        /// <summary>
        ///     Queries the collection test.
        /// </summary>
        [Test]
        public async Task QueryCollectionTest()
        {
            using var client = new TonClient(this.ClientConfig);
            var result = await client.Net.QueryCollection(new ParamsOfQueryCollection
            {
                Collection = "blocks_signatures",
                Result = "id",
                Limit = 1
            });
            Assert.Greater(result.Result.Length, 0);

            result = await client.Net.QueryCollection(new ParamsOfQueryCollection
            {
                Collection = "accounts",
                Result = "id, balance",
                Limit = 5
            });
            Assert.AreEqual(result.Result.Length, 5);

            OrderBy[] order =
            {
                new OrderBy
                {
                    Path = "created_at",
                    Direction = SortDirection.ASC
                }
            };
            //)"{\"created_at\":{\"gt\":1562342740}}"
            result = await client.Net.QueryCollection(new ParamsOfQueryCollection
            {
                Collection = "messages",
                Filter = new Filter("created_at", "gt", "1562342740"),
                Order = order,
                Result = "body created_at",
                Limit = 10
            });
            Assert.Greater(result.Result[0]["created_at"].Value<long>(), 1562342740);
        }

        /// <summary>
        ///     Waits for collection test.
        /// </summary>
        [Test]
        public async Task WaitForCollectionTest()
        {
            var now = DateTime.Now.Millisecond;
            using var client = new TonClient(this.ClientConfig);
            var result = await client.Net.WaitForCollection(new ParamsOfWaitForCollection
            {
                Collection = "transactions",
                Filter = new Filter("now", "gt", now),
                Result = "id now"
            });
            Assert.Greater(result.Result["now"].Value<long>(), now);
        }

        /// <summary>
        ///     Subscribes the collection test.
        /// </summary>
        [Test]
        public async Task SubscribeCollectionTest()
        {
            var now = DateTime.Now.Millisecond;
            var results = new List<string>();
            using var client = new TonClient(this.ClientConfig);
            var generator = await client.Net.SubscribeCollection(new ParamsOfSubscribeCollection
            {
                Collection = "messages",
                Filter = new Filter("{\"created_at\":{\"gt\":" + now + "}}"),
                Result = "created_at"
            }, (param, type) => { results.Add(param); });
            await Task.Factory.StartNew(() => Thread.Sleep(5000));
            await client.Net.Unsubscribe(generator);
            Assert.Greater(results.Count, 0);
        }

        /// <summary>
        ///     Nets the exceptions test.
        /// </summary>
        [Test]
        public async Task NetExceptionsTest()
        {
            await this.CheckException(this.QueryCollectionExceptionTest);
            await this.CheckException(this.WaitForCollectionExceptionTest);
        }

        /// <summary>
        ///     Queries the collection exception test.
        /// </summary>
        public async Task QueryCollectionExceptionTest()
        {
            using var client = new TonClient(this.ClientConfig);
            await client.Net.QueryCollection(new ParamsOfQueryCollection
            {
                Collection = "messages"
            });
        }

        /// <summary>
        ///     Waits for collection exception test.
        /// </summary>
        public async Task WaitForCollectionExceptionTest()
        {
            using var client = new TonClient(this.ClientConfig);
            await client.Net.WaitForCollection(new ParamsOfWaitForCollection
            {
                Collection = "transactions",
                Timeout = 1
            });
        }

        #endregion
    }
}