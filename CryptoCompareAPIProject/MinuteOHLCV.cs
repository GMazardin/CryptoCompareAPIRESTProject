using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace CryptoCompareAPIProject
{
    public class MinuteOHLCV
    {
        public static Root GetData()
        {
            var client =
                new RestClient(
                    "https://min-api.cryptocompare.com/data/v2/histominute?fsym=BTC&tsym=EUR&limit=30&api_key=6740a3181ac4226f342109d2f5502ed122ccbc31605823e7ac11902f657c8d69");
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

        public class RateLimit
        {
        }

        public class Datum
        {
            public int time { get; set; }
            public double high { get; set; }
            public double low { get; set; }
            public double open { get; set; }
            public double volumefrom { get; set; }
            public double volumeto { get; set; }
            public double close { get; set; }
            public string conversionType { get; set; }
            public string conversionSymbol { get; set; }
            public bool Aggregated { get; set; }
            public int TimeFrom { get; set; }
            public int TimeTo { get; set; }
            public List<Datum> Data { get; set; }

            public Datum()
            {
                this.Data = new List<Datum>();
            }
        }

        public class Root
        {
            public string Response { get; set; }
            public string Message { get; set; }
            public bool HasWarning { get; set; }
            public int Type { get; set; }
            public RateLimit RateLimit { get; set; }
            public Datum Data { get; set; }

            public Root()
            {
                this.RateLimit = new RateLimit();
                this.Data = new Datum();
            }
        }
    }
}