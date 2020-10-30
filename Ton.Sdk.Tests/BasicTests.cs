using NUnit.Framework;

namespace Ton.Sdk.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Threading.Tasks;
    using External;
    using Newtonsoft.Json.Linq;
    using Request;

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
            TonClient client = new TonClient(text);
            Console.WriteLine(client.GetVersion().Result.GetValue("version"));

        }

        [Test]
        public void GetApiReferenceTest()
        {
            string text = "{\"{}\": 2 }";
            TonClient client = new TonClient(text);
            Console.WriteLine(client.GetApiReference().Result);

        }

        //[Test]
        //public void MultithreadingGetVersionTest()
        //{
        //    string text = "{\"{}\": 2 }";
        //    tc_string_data_t config = new tc_string_data_t { Value = text };
        //    IntPtr jsonPtr = Lib.tc_create_context(config);
        //    tc_string_data_t json = Lib.tc_read_string(jsonPtr);
        //    var context = JObject.Parse(json.Value)["result"].Value<uint>();

        //    //uint context = parse_create_context_json(json.content, json.len)
        //    RequestLib lib = new RequestLib();
        //    List<Task<Response>> tasks = new List<Task<Response>>();
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        tasks.Add(lib.GetVersion(context));
        //    }

        //    Task.WaitAll(tasks.ToArray());

        //    for (int i = 0; i < tasks.Count; i++)
        //    {
        //        Console.WriteLine(tasks[i].Result.ReturnValue);
        //    }

        //}
    }
}