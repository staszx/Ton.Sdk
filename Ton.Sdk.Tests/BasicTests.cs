using NUnit.Framework;

namespace Ton.Sdk.Tests
{
    using System;
    using System.Text.Json;
    using External;
    using Newtonsoft.Json.Linq;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateContextTest()
        {
            string text = "{\"{}\", 2 }";
            tc_string_data_t config = new tc_string_data_t { Value = text };
            IntPtr jsonPtr = Lib.tc_create_context(config);
            tc_string_data_t json = Lib.tc_read_string(jsonPtr);
            Console.WriteLine(json);
        }

        [Test]
        public void GetVersionTest()
        {
            string text = "{\"{}\": 2 }";
            tc_string_data_t config = new tc_string_data_t { Value = text };
            IntPtr jsonPtr = Lib.tc_create_context(config);
            tc_string_data_t json = Lib.tc_read_string(jsonPtr);
            var context = JObject.Parse(json.Value)["result"].Value<uint>();

            //uint context = parse_create_context_json(json.content, json.len)
             Lib.getVersion(context);
        }
    }
}