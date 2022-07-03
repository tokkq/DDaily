using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace DailyProject.Day
{
    /// <summary>
    /// DailyPage.xaml の相互作用ロジック
    /// </summary>
    public partial class DailyWritePage : Page
    {
        DailyNoteInfo _dailyNoteInfo = new DailyNoteInfo();
        DateTime _date = default;
        string _dailyNoteInfoPath = "";

        public DailyWritePage()
        {
            InitializeComponent();
        }

        public void SetDate(DateTime date)
        {
            _date = date;
            _dailyNoteInfoPath = Path.Combine(PathDefinition.DailyJsonDirectoryPath, $@"{date.Year}{date.Month}{date.Day}.json");
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            var page = new MainPage();
            NavigationService.Navigate(page);
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Label label)
            {
                label.Content = _date.Date;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _dailyNoteInfo = JsonUtility.LoadJson<DailyNoteInfo>(_dailyNoteInfoPath);
            DataContext = _dailyNoteInfo;
        }

        void save(object sender, RoutedEventArgs e)
        {
            JsonUtility.SaveJson(_dailyNoteInfo, _dailyNoteInfoPath);
        }
    }

    class DailyNoteInfo
    {
        public string GoodPoint { get; set; } = "良かった点";
        public string ChangePoint { get; set; } = "変更点";
        public string Target { get; set; } = "目標";
    }
}
