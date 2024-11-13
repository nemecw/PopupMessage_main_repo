using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PopupMessage
{
    public class clsSource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public clsSource()
        {
            isAdded = true;
            isChanged = false;
        }

        public static clsSource CreateNewTemplate()
        {
            return new clsSource();
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if (_ID == value)
                {
                    return;
                }

                _ID = value;

                NotifyPropertyChanged("ID");
            }
        }

        private string _Person;
        public string Person
        {
            get { return _Person; }
            set
            {
                if (_Person == value)
                {
                    return;
                }

                _Person = value;
                isChanged = true;

                NotifyPropertyChanged("Person");
                NotifyPropertyChanged("isChanged");
            }
        }

        private string _Event;
        public string Event
        {
            get { return _Event; }
            set
            {
                if (_Event == value)
                {
                    return;
                }

                _Event = value;
                isChanged = true;

                NotifyPropertyChanged("Event");
                NotifyPropertyChanged("isChanged");
            }
        }

        private string _Comment;
        public string Comment
        {
            get { return _Comment; }
            set
            {
                if (_Comment == value)
                {
                    return;
                }

                _Comment = value;
                isChanged = true;

                NotifyPropertyChanged("Comment");
                NotifyPropertyChanged("isChanged");
            }
        }

        private DateTime _On_Date;
        public DateTime On_Date
        {
            get { return _On_Date; }
            set
            {
                if (_On_Date == value)
                {
                    return;
                }

                _On_Date = value;
                isChanged = true;

                NotifyPropertyChanged("On_Date");
                NotifyPropertyChanged("isChanged");
            }
        }

        private string _Sort;
        public string Sort
        {
            get { return _Sort; }
            set
            {
                if (_Sort == value)
                {
                    return;
                }

                _Sort = value;
                isChanged = true;

                NotifyPropertyChanged("Sort");
            }
        }

        public object[] ItemsArray => new object[] { Person, Event, Comment, On_Date, Sort };

        public bool isAdded { get; set; }
        public bool isChanged { get; set; }
        public bool isShown { get; set; } = false;

    }

}
