using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Data
{
    class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<WeekdayItem> weekdayList;
        public ObservableCollection<WeekdayItem> WeekdayList { get { return weekdayList; } }
        private int selectedItemIndex;
        public int SelectedItemIndex
        {
            get { return selectedItemIndex; }
            set { selectedItemIndex = value; NotifyPropertyChanged("SelectedItemIndex"); }
        }

        public ViewModel()
        {
            weekdayList = new ObservableCollection<WeekdayItem>();
            selectedItemIndex = -1;
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
