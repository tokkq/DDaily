using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DailyProject.Week
{
    /// <summary>
    /// WeeklyWritePage.xaml の相互作用ロジック
    /// </summary>
    public partial class WeeklyWritePage : Page
    {
        WeeklyNoteInfo _weeklyNoteInfo;

        DateTime _date = default;

        public WeeklyWritePage()
        {
            InitializeComponent();

            _weeklyNoteInfo = new WeeklyNoteInfo();
            DataContext = _weeklyNoteInfo;
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }

        void onClickSaveButton(object sender, RoutedEventArgs e)
        {

        }

        void onClickLoadButton(object sender, RoutedEventArgs e)
        {
            load(@"C:\TokkqFiles\WorkSpace\Projects\DailyProject\test.json");
        }

        void save()
        {

        }

        void load(string path)
        {
            var json = JsonUtility.LoadJson<WeeklyNoteInfo>(path);
            Debug.WriteLine(json.ChangePoint);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                JsonUtility.SaveJson(_weeklyNoteInfo, @"C:\TokkqFiles\WorkSpace\Projects\DailyProject\test.json");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

    public class WeeklyNoteInfo
    {
        public string GoodPoint { get; set; } = "良かった点";
        public string ChangePoint { get; set; } = "変更点";
        public string Target { get; set; } = "目標";
    }
}
