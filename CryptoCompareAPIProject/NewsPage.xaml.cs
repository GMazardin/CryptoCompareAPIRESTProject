using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace CryptoCompareAPIProject
{
    public partial class NewsPage : Page
    {
        
        public class NewsData
        {
            public string Image { get; set; }
            public string Source { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }
        }
        
        public NewsPage()
        {
            InitializeComponent();
            LatestNews.Root NewsSrc = new LatestNews.Root();
            NewsSrc = LatestNews.GetData();

            var list = new ObservableCollection<NewsData>();
            for (int i = 0; i < NewsSrc.Data.Count; i++)
            {
                list.Add(new NewsData()
                {
                    Image = NewsSrc.Data[i].imageurl, Source = NewsSrc.Data[i].source, Title = NewsSrc.Data[i].title,
                    Url = NewsSrc.Data[i].url
                });
            }

            Console.WriteLine(NewsSrc.Data[1].imageurl);
            this.DataGrid1.ItemsSource = list;
        }
        
        private void DG_Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink link = (Hyperlink) e.OriginalSource;
            Process.Start(link.NavigateUri.AbsoluteUri);
        }
    }
}