using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;

namespace mytelegramm
{
    //public class ChatItem : INotifyPropertyChanged
    //{
    //    private BitmapImage _image;
    //    private string _chatName;
    //    private string _lastMessage;

    //    public BitmapImage Image
    //    {
    //        get { return _image; }
    //        set
    //        {
    //            _image = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public string ChatName
    //    {
    //        get { return _chatName; }
    //        set
    //        {
    //            _chatName = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public string LastMessage
    //    {
    //        get { return _lastMessage; }
    //        set
    //        {
    //            _lastMessage = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    //тут мы наследуем класс дабы изменения были динамически
    //не забываем при инициализации объекта класса DataContext = person;
    public class Person : INotifyPropertyChanged 
    {
        private string _name;
        private string _username;
        private int _password;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }
        public int Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Content = new myregister();
        }

  

    }
}
