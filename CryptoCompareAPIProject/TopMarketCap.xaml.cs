using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace CryptoCompareAPIProject
{
    public partial class TopMarketCap : Page
    {
        public class EUR
        {
            public string FROMSYMBOL { get; set; }
            public double PRICE { get; set; }
            public double VOLUME24HOUR { get; set; }
            public double MKTCAP { get; set; }
            public double TOTALVOLUME24H { get; set; }
        }

        public TopMarketCap()
        {
            InitializeComponent();
            ToplistMarketCap.Root EurInfo = new ToplistMarketCap.Root();
            EurInfo = ToplistMarketCap.GetData();

            var eurlist = new ObservableCollection<EUR>();
            for (int i = 0; i < EurInfo.Data.Count; i++)
            {
                eurlist.Add(new EUR()
                {
                    FROMSYMBOL = EurInfo.Data[i].RAW.EUR.FROMSYMBOL, PRICE = EurInfo.Data[i].RAW.EUR.PRICE,
                    VOLUME24HOUR = EurInfo.Data[i].RAW.EUR.VOLUME24HOUR,
                    MKTCAP = EurInfo.Data[i].RAW.EUR.MKTCAP, TOTALVOLUME24H = EurInfo.Data[i].RAW.EUR.TOTALVOLUME24H
                });
            }

            this.DataGrid2.ItemsSource = eurlist;
        }
    }
}