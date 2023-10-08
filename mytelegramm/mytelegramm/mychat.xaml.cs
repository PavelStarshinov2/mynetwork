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
    public class VariableWrapper : INotifyPropertyChanged
    {
        private bool _delete;
        public bool delete
        {
            get { return _delete; }
            set
            {
                _delete = value;
                OnPropertyChanged(nameof(delete));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class ChatItem : INotifyPropertyChanged
    {
        
        private BitmapImage _image;
        private string _chatName;
        private string _lastMessage;

        public BitmapImage Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        public string ChatName
        {
            get { return _chatName; }
            set
            {
                _chatName = value;
                OnPropertyChanged();
            }
        }

        public string LastMessage
        {
            get { return _lastMessage; }
            set
            {
                _lastMessage = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    /// <summary>
    /// Логика взаимодействия для mychat.xaml
    /// </summary>

    public partial class mychat : Page
    {
       

        VariableWrapper variableWrapper = new VariableWrapper();
        //тут мы используем ObservableCollection так как при добавлении нового объекта класса он сразу обновляет ListView
        public ObservableCollection<ChatItem> chatItems { get; set; }
        public mychat()
        {
            InitializeComponent();
            chatItems = new ObservableCollection<ChatItem>();

            ChatItem chatItem1 = new ChatItem();
            chatItem1.Image = new BitmapImage(new Uri("image/избранное.jpg", UriKind.RelativeOrAbsolute));
            chatItem1.ChatName = "Chat 1";
            chatItem1.LastMessage = "Hello!";


            ChatItem chatItem3 = new ChatItem();
            chatItem3.Image = new BitmapImage(new Uri("image/избранное.jpg", UriKind.RelativeOrAbsolute));
            chatItem3.ChatName = "Chat 3";
            chatItem3.LastMessage = "Nice to meet you!";

            chatItems.Add(chatItem1);

            chatItems.Add(chatItem3);
            DataContext = this;
        }


        private void DockPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

            // Получаем ссылку на родительское окно (MainWindow)
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            // Получаем ссылку на Frame
            Frame myFrame = (Frame)mainWindow.FindName("NavigationFrame");
            myFrame.Content = new chatselected();







        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //// Находим первый объект ChatItem с заданным значением ChatName
            //ChatItem chatItem = chatItems.FirstOrDefault(item => item.ChatName == "Chat 1");

            //if (chatItem != null)
            //{
            //    // Изменяем название чата
            //    chatItem.ChatName = "Новое название чата";
            //}



            ChatItem chatItem1 = new ChatItem();
            chatItem1.Image = new BitmapImage(new Uri("image/избранное.jpg", UriKind.RelativeOrAbsolute));
            chatItem1.ChatName = "Chat 1";
            chatItem1.LastMessage = "Hello!";
            chatItems.Add(chatItem1);
        }
        private void deletechat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            variableWrapper.delete = !variableWrapper.delete;
            if (variableWrapper.delete == true)
            {
                deletechat.Text = "Готово";
                chekbox.IsChecked = true;
            }
            else
            {
                deletechat.Text = "Изм.";
                chekbox.IsChecked = false;
            }

        }
    }
}
