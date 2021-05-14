using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyWebClient
{
    public class EasyWebClient:IEasyWebClient
    {
        public Uri EndPoint { get; set; }

        public EasyWebClient(Uri endPoint)
        {
            EndPoint = endPoint;
        }

        public string Get()
        {
            return "test";
        }

        public string Get(params KeyValuePair<string, string>[] queries)
        {
            throw new NotImplementedException();
        }

        public string Post(byte[] content)
        {
            throw new NotImplementedException();
        }

        public string Post(byte[] content, params KeyValuePair<string, string>[] queries)
        {
            throw new NotImplementedException();
        }

        public string Put(byte[] content)
        {
            throw new NotImplementedException();
        }

        public string Put(byte[] content, params KeyValuePair<string, string>[] queries)
        {
            throw new NotImplementedException();
        }

        public string Delete(params KeyValuePair<string, string>[] queries)
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public void AddHeader(string name, string value)
        {
            throw new NotImplementedException();
        }
    }

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
