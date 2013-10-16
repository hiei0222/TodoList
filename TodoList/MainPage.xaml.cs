using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TodoList.Data;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace TodoList
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ViewModel viewModel;
        public MainPage()
        {
            viewModel = new ViewModel();
            addData();
            this.DataContext = viewModel;
            this.InitializeComponent();
        }

        /// <summary>
        /// 往viewModel添加数据
        /// </summary>
        private void addData()
        {
            WeekdayItem monday = new WeekdayItem();
            monday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-215",
                StartTime = "8:30",
                EndTime = "10:00",
                LessonName = "Math"
            });
            monday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-216",
                StartTime = "10:30",
                EndTime = "12:00",
                LessonName = "Physic"
            });
            monday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "E-303",
                StartTime = "14:30",
                EndTime = "16:00",
                LessonName = "Computer"
            });
            monday.Weekday = "月曜日";
            viewModel.WeekdayList.Add(monday);
            WeekdayItem tuesday = new WeekdayItem();
            tuesday.Weekday = "火曜日";
            tuesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-215",
                StartTime = "8:30",
                EndTime = "10:00",
                LessonName = "Math"
            });
            tuesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-216",
                StartTime = "10:30",
                EndTime = "12:00",
                LessonName = "Physic"
            });
            tuesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "E-303",
                StartTime = "14:30",
                EndTime = "16:00",
                LessonName = "English"
            });
            viewModel.WeekdayList.Add(tuesday);

            WeekdayItem wednesday = new WeekdayItem();
            wednesday.Weekday = "水曜日";
            wednesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-215",
                StartTime = "8:30",
                EndTime = "10:00",
                LessonName = "数学"
            });
            wednesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-216",
                StartTime = "10:30",
                EndTime = "12:00",
                LessonName = "Physic"
            });
            wednesday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "E-303",
                StartTime = "14:30",
                EndTime = "16:00",
                LessonName = "English"
            });
            viewModel.WeekdayList.Add(wednesday);
            WeekdayItem thursday = new WeekdayItem();
            thursday.Weekday = "木曜日";
            thursday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-215",
                StartTime = "8:30",
                EndTime = "10:00",
                LessonName = "数学"
            });
            thursday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-216",
                StartTime = "10:30",
                EndTime = "12:00",
                LessonName = "Physic"
            });
            thursday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "E-303",
                StartTime = "14:30",
                EndTime = "16:00",
                LessonName = "English"
            });
            viewModel.WeekdayList.Add(thursday);
            WeekdayItem friday = new WeekdayItem();
            friday.Weekday = "金曜日";
            friday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-215",
                StartTime = "8:30",
                EndTime = "10:00",
                LessonName = "数学"
            });
            friday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "B-216",
                StartTime = "10:30",
                EndTime = "12:00",
                LessonName = "Physic"
            });
            friday.ScheduleList.Add(new ScheduleItem
            {
                ClassRoom = "E-303",
                StartTime = "14:30",
                EndTime = "16:00",
                LessonName = "English"
            });
            viewModel.WeekdayList.Add(friday);

        }



        //public MainPage()
        // {
        //    this.InitializeComponent();
        //}

        /// <summary>
        /// このページがフレームに表示されるときに呼び出されます。
        /// </summary>
        /// <param name="e">このページにどのように到達したかを説明するイベント データ。Parameter 
        /// プロパティは、通常、ページを構成するために使用します。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
