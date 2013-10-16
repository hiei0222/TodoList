using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Data
{
    class ScheduleItem : INotifyPropertyChanged
    {
        private string lessonName;
        public string LessonName
        {
            get { return lessonName; }
            set
            {
                lessonName = value;
                NotifyPropertyChanged("LessonName");
            }
        }
        private string startTime;
        public string StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
                NotifyPropertyChanged("StartTme");
            }
        }

        private string endTime;
        public string EndTime
        {
            get { return endTime; }
            set
            {
                endTime = value;
                NotifyPropertyChanged("EndTime");
            }
        }

        private string classRoom;
        public string ClassRoom
        {
            get { return classRoom; }
            set { classRoom = value; NotifyPropertyChanged("ClassRoom"); }
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
