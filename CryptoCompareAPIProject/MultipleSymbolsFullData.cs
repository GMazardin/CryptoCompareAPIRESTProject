using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace CryptoCompareAPIProject
{
    public class MultipleSymbolsFullData
    {
        public static Root GetData()
        {
            var client =
                new RestClient(
                    "https://min-api.cryptocompare.com/data/pricemultifull?fsyms=BTC&tsyms=EUR&api_key=6740a3181ac4226f342109d2f5502ed122ccbc31605823e7ac11902f657c8d69");
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

        public static void test() // Test function to show you that GetData() returns a whole package in which you can take whatever you want
        {
            Root root = GetData();
            Console.WriteLine(root.RAW.BTC.EUR.PRICE);
        }

        public class EUR
        {
            public string TYPE { get; set; }
            public string MARKET { get; set; }
            public string FROMSYMBOL { get; set; }
            public string TOSYMBOL { get; set; }
            public string FLAGS { get; set; }
            public float PRICE { get; set; }
            public float LASTUPDATE { get; set; }
            public float MEDIAN { get; set; }
            public float LASTVOLUME { get; set; }
            public float LASTVOLUMETO { get; set; }
            public string LASTTRADEID { get; set; }
            public float VOLUMEDAY { get; set; }
            public float VOLUMEDAYTO { get; set; }
            public float VOLUME24HOUR { get; set; }
            public float VOLUME24HOURTO { get; set; }
            public float OPENDAY { get; set; }
            public float HIGHDAY { get; set; }
            public float LOWDAY { get; set; }
            public float OPEN24HOUR { get; set; }
            public float HIGH24HOUR { get; set; }
            public float LOW24HOUR { get; set; }
            public string LASTMARKET { get; set; }
            public float VOLUMEHOUR { get; set; }
            public float VOLUMEHOURTO { get; set; }
            public float OPENHOUR { get; set; }
            public float HIGHHOUR { get; set; }
            public float LOWHOUR { get; set; }
            public float TOPTIERVOLUME24HOUR { get; set; }
            public float TOPTIERVOLUME24HOURTO { get; set; }
            public float CHANGE24HOUR { get; set; }
            public float CHANGEPCT24HOUR { get; set; }
            public float CHANGEDAY { get; set; }
            public float CHANGEPCTDAY { get; set; }
            public float CHANGEHOUR { get; set; }
            public float CHANGEPCTHOUR { get; set; }
            public string CONVERSIONTYPE { get; set; }
            public string CONVERSIONSYMBOL { get; set; }
            public float SUPPLY { get; set; }
            public float MKTCAP { get; set; }
            public float MKTCAPPENALTY { get; set; }
            public float CIRCULATINGSUPPLY { get; set; }
            public float CIRCULATINGSUPPLYMKTCAP { get; set; }
            public float TOTALVOLUME24H { get; set; }
            public float TOTALVOLUME24HTO { get; set; }
            public float TOTALTOPTIERVOLUME24H { get; set; }
            public float TOTALTOPTIERVOLUME24HTO { get; set; }
            public string IMAGEURL { get; set; }
        }

        public class BTC
        {
            public EUR EUR { get; set; }

            public BTC()
            {
                this.EUR = new EUR();
            }
        }

        public class RAW
        {
            public BTC BTC { get; set; }

            public RAW()
            {
                this.BTC = new BTC();
            }
        }

        public class Root
        {
            public RAW RAW { get; set; }

            public Root()
            {
                this.RAW = new RAW();
            }
        }
    }
}