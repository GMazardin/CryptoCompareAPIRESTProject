using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CryptoCompareAPIProject
{
    public partial class Graph : Page
    {
        public Graph()
        {
            InitializeComponent();
            MinuteOHLCV.Root OHLC_Data = new MinuteOHLCV.Root();
            OHLC_Data = MinuteOHLCV.GetData();
            var close = new ObservableCollection<double>();
            var time = new ObservableCollection<double>();
            for (int i = 0; i < OHLC_Data.Data.Data.Count; i++)
            {
                close.Add(OHLC_Data.Data.Data[i].close);
                time.Add(OHLC_Data.Data.Data[i].time);
            }

            double[] close_data = close.ToArray();
            double[] time_data = time.ToArray();

            //var WpfPlot1 = new ScottPlot.Plot(600, 400);
            WpfPlot1.Plot.AddScatter(time_data, close_data);
            WpfPlot1.Plot.XAxis.DateTimeFormat(true);
            WpfPlot1.Plot.SaveFig("../../finance_quickstart.png");
            WpfPlot1.Plot.Title("BTC to EUR Evolution during the last 30 minutes");
            WpfPlot1.Refresh();
        }
    }
}