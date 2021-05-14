using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests.tools
{
    public class ReceivedRequest
    {
        public IList<KeyValue> Headers { get; set; } = new List<KeyValue>();
        public IList<KeyValue> QueryValues { get; set; } = new List<KeyValue>();
        public string Body { get; set; }
        public Uri Url { get; set; }
        public string Method { get; set; }
    }

    public class KeyValue
    {
        public KeyValue(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
