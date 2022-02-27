using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace CryptoCompareAPIProject
{
    public class LatestNews
    {
        public static Root GetData()
        {
            var client =
                new RestClient(
                    "https://min-api.cryptocompare.com/data/v2/news/?lang=EN&api_key=6740a3181ac4226f342109d2f5502ed122ccbc31605823e7ac11902f657c8d69");
            var request = new RestRequest();
            var response = client.Execute(request);
            Root result = new Root();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string RawResponse = response.Content;
                result = JsonConvert.DeserializeObject<Root>(RawResponse);
            }

            return result;
        }
        
        
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class SourceInfo
        {
            public string name { get; set; }
            public string lang { get; set; }
            public string img { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string guid { get; set; }
            public int published_on { get; set; }
            public string imageurl { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string source { get; set; }
            public string body { get; set; }
            public string tags { get; set; }
            public string categories { get; set; }
            public string upvotes { get; set; }
            public string downvotes { get; set; }
            public string lang { get; set; }
            public SourceInfo source_info { get; set; }

            public Datum()
            {
                this.source_info = new SourceInfo();
            }
        }

        public class RateLimit
        {
        }

        public class Root
        {
            public int Type { get; set; }
            public string Message { get; set; }
            public List<object> Promoted { get; set; }
            public List<Datum> Data { get; set; }
            public RateLimit RateLimit { get; set; }
            public bool HasWarning { get; set; }

            public Root()
            {
                this.Data = new List<Datum>();
                this.RateLimit = new RateLimit();
            }
        }
    }
}