using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;

namespace CryptoCompareAPIProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new TopMarketCap();
        }


        private void ButtonClickMKTCap(object sender, RoutedEventArgs e)
        {
            Main.Content = new TopMarketCap();
        }

        private void ButtonClickGraph(object sender, RoutedEventArgs e)
        {
            Main.Content = new Graph();
        }

        private void ButtonClickNews(object sender, RoutedEventArgs e)
        {
            Main.Content = new NewsPage();
        }
    }
}