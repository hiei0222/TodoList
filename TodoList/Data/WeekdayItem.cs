using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Data
{
    class WeekdayItem : INotifyPropertyChanged
    {
        private ObservableCollection<ScheduleItem> scheduleList;
        private int scheduleSelected;
        public int ScheduleSelected
        {
            get { return scheduleSelected; }
            set { scheduleSelected = value; NotifyPropertyChanged("ScheduleSelected"); }
        }
        public ObservableCollection<ScheduleItem> ScheduleList
        {
            get { return scheduleList; }
        }
        public WeekdayItem()
        {
            scheduleList = new ObservableCollection<ScheduleItem>();
            weekday = "Monday";
        }
        private string weekday;
        public string Weekday
        {
            get { return weekday; }
            set { weekday = value; NotifyPropertyChanged("WeekDay"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }

}
