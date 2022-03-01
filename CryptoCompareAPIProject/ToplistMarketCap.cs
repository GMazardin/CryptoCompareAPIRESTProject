using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace CryptoCompareAPIProject
{
    public class ToplistMarketCap
    {
        public static Root GetData()
        {
            var client =
                new RestClient(
                    "https://min-api.cryptocompare.com/data/top/mktcapfull?limit=30&tsym=EUR&api_key=6740a3181ac4226f342109d2f5502ed122ccbc31605823e7ac11902f657c8d69");
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

        public class Weiss
        {
            public string Rating { get; set; }
            public string TechnologyAdoptionRating { get; set; }
            public string MarketPerformanceRating { get; set; }
        }

        public class Rating
        {
            public Weiss Weiss { get; set; }

            public Rating()
            {
                this.Weiss = new Weiss();
            }
        }

        public class CoinInfo
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string FullName { get; set; }
            public string Internal { get; set; }
            public string ImageUrl { get; set; }
            public string Url { get; set; }
            public string Algorithm { get; set; }
            public string ProofType { get; set; }
            public Rating Rating { get; set; }
            public object NetHashesPerSecond { get; set; }
            public double BlockNumber { get; set; }
            public double BlockTime { get; set; }
            public double BlockReward { get; set; }
            public string AssetLaunchDate { get; set; }
            public double MaxSupply { get; set; }
            public int Type { get; set; }
            public string DocumentType { get; set; }
        }

        public class EUR
        {
            public string TYPE { get; set; }
            public string MARKET { get; set; }
            public string FROMSYMBOL { get; set; }
            public string TOSYMBOL { get; set; }
            public string FLAGS { get; set; }
            public double PRICE { get; set; }
            public double LASTUPDATE { get; set; }
            public double MEDIAN { get; set; }
            public double LASTVOLUME { get; set; }
            public double LASTVOLUMETO { get; set; }
            public string LASTTRADEID { get; set; }
            public double VOLUMEDAY { get; set; }
            public double VOLUMEDAYTO { get; set; }
            public double VOLUME24HOUR { get; set; }
            public double VOLUME24HOURTO { get; set; }
            public double OPENDAY { get; set; }
            public double HIGHDAY { get; set; }
            public double LOWDAY { get; set; }
            public double OPEN24HOUR { get; set; }
            public double HIGH24HOUR { get; set; }
            public double LOW24HOUR { get; set; }
            public string LASTMARKET { get; set; }
            public double VOLUMEHOUR { get; set; }
            public double VOLUMEHOURTO { get; set; }
            public double OPENHOUR { get; set; }
            public double HIGHHOUR { get; set; }
            public double LOWHOUR { get; set; }
            public double TOPTIERVOLUME24HOUR { get; set; }
            public double TOPTIERVOLUME24HOURTO { get; set; }
            public double CHANGE24HOUR { get; set; }
            public double CHANGEPCT24HOUR { get; set; }
            public double CHANGEDAY { get; set; }
            public double CHANGEPCTDAY { get; set; }
            public double CHANGEHOUR { get; set; }
            public double CHANGEPCTHOUR { get; set; }
            public string CONVERSIONTYPE { get; set; }
            public string CONVERSIONSYMBOL { get; set; }
            public double SUPPLY { get; set; }
            public double MKTCAP { get; set; }
            public int MKTCAPPENALTY { get; set; }
            public double CIRCULATINGSUPPLY { get; set; }
            public double CIRCULATINGSUPPLYMKTCAP { get; set; }
            public double TOTALVOLUME24H { get; set; }
            public double TOTALVOLUME24HTO { get; set; }
            public double TOTALTOPTIERVOLUME24H { get; set; }
            public double TOTALTOPTIERVOLUME24HTO { get; set; }
            public string IMAGEURL { get; set; }
        }

        public class RAW
        {
            public EUR EUR { get; set; }

            public RAW()
            {
                this.EUR = new EUR();
            }
        }

        public class Datum
        {
            public CoinInfo CoinInfo { get; set; }
            public RAW RAW { get; set; }

            public Datum()
            {
                this.CoinInfo = new CoinInfo();
                this.RAW = new RAW();
            }
        }

        public class RateLimit
        {
        }

        public class Root
        {
            public string Message { get; set; }
            public int Type { get; set; }
            public List<Datum> Data { get; set; }
            public RateLimit RateLimit { get; set; }
            public bool HasWarning { get; set; }
        }
    }
}