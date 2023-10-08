using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mytelegramm
{
    public class SoobItem : INotifyPropertyChanged
    {
        private string _datesend;
        private string _lastMessage;
        public string LastMessage
        {
            get { return _lastMessage; }
            set
            {
                _lastMessage = value;
                OnPropertyChanged();
            }
        }
        
        public string Datesend
        {
            get { return _datesend; }
            set
            {
                _datesend = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public partial class chatselected : Page
    {
        public ObservableCollection<SoobItem> soob { get; set; }
        public chatselected()
        {
            InitializeComponent();
            soob = new ObservableCollection<SoobItem>();
            DataContext = this;
        }

        private void soob1_KeyUp(object sender, KeyEventArgs e)
        {
            if (soob1.Text != "")
            {
                if (e.Key == Key.Enter)
                {
                    SoobItem soobItem = new SoobItem();
                    soobItem.LastMessage = soob1.Text;
                    DateTime localTime = DateTime.Now;
                    soobItem.Datesend = localTime.ToString("HH:mm");
                    soob1.Text = "";
                    soob.Add(soobItem);
                    mylist1.ScrollIntoView(soobItem);
                }
            }

        }

        private void sendsob(object sender, RoutedEventArgs e)
        {
            if (soob1.Text != "")
            {
                SoobItem soobItem = new SoobItem();
                soobItem.LastMessage = soob1.Text;
                DateTime localTime = DateTime.Now;
                soobItem.Datesend = localTime.ToString("HH:mm");
                soob1.Text = "";
                soob.Add(soobItem);
                mylist1.ScrollIntoView(soobItem);
            }
        }
    }
}
