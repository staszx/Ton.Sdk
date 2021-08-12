namespace Ton.Sdk.Tests
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;
    using Abi;
    using Client;
    using Exceptions;
    using Newtonsoft.Json;
    using NUnit.Framework;
    using Processing;

    /// <summary>
    ///     The TON client test common module
    /// </summary>
    public class TonClientTestCommon
    {
        #region Delegates

        public delegate Task TestException();

        #endregion

        #region Constants

        /// <summary>
        ///     The dev host
        /// </summary>
        public const string DevHost = "net.ton.dev";

        /// <summary>
        ///     The giver address
        /// </summary>
        public const string GiverAddress = "0:653b9a6452c7a982c6dc92b2da9eba832ade1c467699ebb3b43dca6d77b780dd";

        /// <summary>
        ///     The library version
        /// </summary>
        public const string LibVersion = "1.20.1";

        /// <summary>
        /// The account
        /// </summary>
        public const string Account = "te6ccgECHQEAA/wAAnfAArtKDoOR5+qId/SCUGSSS9Qc4RD86X6TnTMjmZ4e+7EyOobmQvsHNngAAAg6t/34DgJWKJuuOehjU0ADAQFBlcBqp0PR+QAN1kt1SY8QavS350RCNNfeZ+ommI9hgd/gAgBToB6t2E3E7a7aW2YkvXv2hTmSWVRTvSYmCVdH4HjgZ4Z94AAAAAvsHNwwAib/APSkICLAAZL0oOGK7VNYMPShBgQBCvSkIPShBQAAAgEgCgcBAv8IAf5/Ie1E0CDXScIBn9P/0wD0Bfhqf/hh+Gb4Yo4b9AVt+GpwAYBA9A7yvdcL//hicPhjcPhmf/hh4tMAAY4SgQIA1xgg+QFY+EIg+GX5EPKo3iP4RSBukjBw3vhCuvLgZSHTP9MfNCD4I7zyuSL5ACD4SoEBAPQOIJEx3vLQZvgACQA2IPhKI8jLP1mBAQD0Q/hqXwTTHwHwAfhHbvJ8AgEgEQsCAVgPDAEJuOiY/FANAdb4QW6OEu1E0NP/0wD0Bfhqf/hh+Gb4Yt7RcG1vAvhKgQEA9IaVAdcLP3+TcHBw4pEgjjJfM8gizwv/Ic8LPzExAW8iIaQDWYAg9ENvAjQi+EqBAQD0fJUB1ws/f5NwcHDiAjUzMehfAyHA/w4AmI4uI9DTAfpAMDHIz4cgzo0EAAAAAAAAAAAAAAAAD3RMfijPFiFvIgLLH/QAyXH7AN4wwP+OEvhCyMv/+EbPCwD4SgH0AMntVN5/+GcBCbkWq+fwEAC2+EFujjbtRNAg10nCAZ/T/9MA9AX4an/4Yfhm+GKOG/QFbfhqcAGAQPQO8r3XC//4YnD4Y3D4Zn/4YeLe+Ebyc3H4ZtH4APhCyMv/+EbPCwD4SgH0AMntVH/4ZwIBIBUSAQm7Fe+TWBMBtvhBbo4S7UTQ0//TAPQF+Gp/+GH4Zvhi3vpA1w1/ldTR0NN/39cMAJXU0dDSAN/RVHEgyM+FgMoAc89AzgH6AoBrz0DJc/sA+EqBAQD0hpUB1ws/f5NwcHDikSAUAISOKCH4I7ubIvhKgQEA9Fsw+GreIvhKgQEA9HyVAdcLP3+TcHBw4gI1MzHoXwb4QsjL//hGzwsA+EoB9ADJ7VR/+GcCASAYFgEJuORhh1AXAL74QW6OEu1E0NP/0wD0Bfhqf/hh+Gb4Yt7U0fhFIG6SMHDe+EK68uBl+AD4QsjL//hGzwsA+EoB9ADJ7VT4DyD7BCDQ7R7tU/ACMPhCyMv/+EbPCwD4SgH0AMntVH/4ZwIC2hsZAQFIGgAs+ELIy//4Rs8LAPhKAfQAye1U+A/yAAEBSBwAWHAi0NYCMdIAMNwhxwDcIdcNH/K8UxHdwQQighD////9vLHyfAHwAfhHbvJ8";

        #endregion

        #region Fields

        /// <summary>
        ///     The client configuration
        /// </summary>
        public ClientConfig ClientConfig = new ClientConfig(DevHost);

        #endregion

        #region Fields

        /// <summary>
        ///     The base path
        /// </summary>
        private readonly string basePath;

        /// <summary>
        ///     The sample path
        /// </summary>
        private readonly string samplePath;

        /// <summary>
        ///     The stopwatch
        /// </summary>
        private Stopwatch stopwatch;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TonClientTestCommon" /> class.
        /// </summary>
        public TonClientTestCommon()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            this.basePath = this.GetParentFolder(currentDirectory, 3);
            this.samplePath = Path.Combine(this.basePath, "Samples");
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Start test: " + TestContext.CurrentContext.Test.Name);
            this.stopwatch = new Stopwatch();
            this.stopwatch.Start();
        }

        /// <summary>
        ///     Tears down.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.stopwatch.Stop();
            Console.WriteLine("Stop test: " + TestContext.CurrentContext.Test.Name);
            Console.WriteLine("Executed time: {0} ms", this.stopwatch.ElapsedMilliseconds);
        }

        /// <summary>
        ///     Loads the contract abi.
        /// </summary>
        /// <returns></returns>
        protected string LoadSample(string fileName, bool asBase64 = false)
        {
            var path = Path.Combine(this.samplePath, fileName);
            if (asBase64)
            {
                var bytes = File.ReadAllBytes(path);
                return Convert.ToBase64String(bytes);
            }

            return File.ReadAllText(path);
        }

        /// <summary>
        ///     Seralizes the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        protected static string SeralizeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        /// <summary>
        ///     Checks the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="expectedJson">The expected json.</param>
        /// <param name="testName">Name of the test.</param>
        protected void Check(object obj, string expectedJson, string testName = "")
        {
            var actualValue = SeralizeObject(obj);
            this.Check(actualValue, expectedJson, testName);
        }

        /// <summary>
        ///     Checks the object.
        /// </summary>
        /// <param name="actualValue">The actual value.</param>
        /// <param name="expectedValue">The expected value.</param>
        /// <param name="testName">The message text.</param>
        protected void Check(string actualValue, string expectedValue, string testName = "")
        {
            testName = testName != "" ? "'" + testName + "'" : "";
            var exceptionMessage = testName != ""
                ? string.Format("Test {2} error\nactualValue={0}\nexpectedValue={1}", actualValue, expectedValue, testName)
                : null;
            Assert.AreEqual(expectedValue, actualValue, exceptionMessage);
            if (testName != "")
            {
                Console.WriteLine("Test part: {0} success executed!", testName);
            }
        }

        /// <summary>
        ///     Checks the exception.
        /// </summary>
        /// <param name="testException">The test exception.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="NullReferenceException">Test method is null</exception>
        /// <exception cref="Exception"></exception>
        protected async Task CheckException(TestException testException, string name = null)
        {
            name = name ?? testException.Method.Name;
            if (testException == null)
            {
                throw new NullReferenceException("Test method is null");
            }

            try
            {
                await testException.Invoke();
                throw new Exception(string.Format("The method {0} test exception failed!", name));
            }
            catch (TonClientInternalException)
            {
                Console.WriteLine("The method {0} test exception success!", name);
            }
        }

        /// <summary>
        ///     Sends the parameter.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="address">The address.</param>
        protected async Task SendParam(TonClient client, string address)
        {
            var abi = this.LoadSample("Giver.abi.json");
            var callSet = new CallSet("grant", null, "{\"addr\":\"" + address + "\"}");
            await client.Processing.ProcessMessage(new ParamsOfProcessMessage
            {
                MessageEncodeParams = new ParamsOfEncodeMessage
                {
                    ContractAbi = new ContractAbi(abi),
                    Signer = new Signer(),
                    Address = GiverAddress,
                    CallSet = callSet
                },
                SendEvents = false
            });
        }

        /// <summary>
        ///     Gets the parent folder.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="level">The level.</param>
        /// <returns></returns>
        private string GetParentFolder(string path, int level)
        {
            for (var i = 0; i < level; i++)
            {
                path = Path.Combine(path, "..");
            }

            return Path.GetFullPath(path);
        }

        #endregion
    }
}