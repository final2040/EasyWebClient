using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyWebClient
{
    public interface IEasyWebClient
    {
        Uri EndPoint { get; set; }
        string Get();
        string Get(params KeyValuePair<string, string>[] queries);
        string Post(byte[] content);
        string Post(byte[] content, params KeyValuePair<string, string>[] queries);
        string Put(byte[] content);
        string Put(byte[] content, params KeyValuePair<string, string>[] queries);
        string Delete(params KeyValuePair<string, string>[] queries);
        string Delete();
        void AddHeader(string name, string value);

    }
}
