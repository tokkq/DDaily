using System;
using System.Windows;

namespace DailyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var uri = new Uri("/MainPage.xaml", UriKind.Relative);
            frame.Source = uri;
        }
    }
}
