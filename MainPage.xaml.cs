using DailyProject.Day;
using DailyProject.Week;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;

namespace DailyProject
{
    /// <summary>
    /// MainPage.xaml の相互作用ロジック
    /// </summary>
    public partial class MainPage : Page
    {
        DailyWritePage _dailyWritePage = null;
        WeeklyWritePage _weeklyWritePage = null;

        DateTime _selectedDate = default;

        public MainPage()
        {
            InitializeComponent();

            _dailyWritePage = new DailyWritePage();
            _weeklyWritePage = new WeeklyWritePage();
        }

        private void GoToDailyWritePage(object sender, RoutedEventArgs e)
        {
            _dailyWritePage.SetDate(_selectedDate);
            var result = NavigationService.Navigate(_dailyWritePage);
        }

        private void GoToWeeklyWritePage(object sender, RoutedEventArgs e)
        {
            _dailyWritePage.SetDate(_selectedDate);
            var result = NavigationService.Navigate(_weeklyWritePage);
        }

        private void GoToWeeklyCheckPage(object sender, RoutedEventArgs e)
        {

        }

        private void Calendar_Initialized(object sender, System.EventArgs e)
        {

        }

        private void Calendar_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Calendar calendar)
            {
                setSelectedDateFromCalendar(calendar);
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is Calendar calendar)
            {
                setSelectedDateFromCalendar(calendar);
            }
        }

        void setSelectedDateFromCalendar(Calendar calendar)
        {
            var isSelectedDate = calendar.SelectedDate.HasValue;
            if (isSelectedDate == true)
            {
                var selectedDate = calendar.SelectedDate.Value;
                _selectedDate = selectedDate;

                Debug.WriteLine($"Set selected date. [selectedDate]{selectedDate}");
            }
            else
            {
                var selectedDate = calendar.DisplayDate.Date;
                _selectedDate = selectedDate;

                Debug.WriteLine($"Set selected date. [selectedDate]{selectedDate}");
            }
        }

        void Calendar_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            Debug.WriteLine("AAAAA");
        }

        void Calendar_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("AAAAA");
        }

        void Calendar_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if ((Mouse.Captured is Calendar) || (Mouse.Captured is CalendarItem))
            {
                var result = Mouse.Capture(null);
            }
        }
    }
}
