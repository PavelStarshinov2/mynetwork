using System;
using System.Collections.Generic;
using System.Linq;
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

namespace vrem
{
    public class Person
    {
        public Person(string name,double password)
        {
            this.name = name;
            this.password = password;
        }
        string name;
        double password;
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Получение фокуса");
        }
        public void soob(TextBlock text, int kuda)
        {
            TextBlock textvrem = new TextBlock(); textvrem.Text = text.Text;
            if (kuda == 1)
            {
                textvrem.HorizontalAlignment = HorizontalAlignment.Left;
                textvrem.FontSize = 20;
                mylist1.Children.Add(textvrem);
            }
            else if (kuda == 2)
            {
                textvrem.HorizontalAlignment = HorizontalAlignment.Left;
                textvrem.FontSize = 20;
                mylist2.Children.Add(textvrem);
            }
        }
        int i = 1;
        private void Register(object sender, RoutedEventArgs e)
        {
            if (i < 3)
            {
                if (namepeople.Text != "" && passwordpeople.Password != "")
                {
                    new Person(namepeople.Text, Convert.ToDouble(passwordpeople.Password));
                    if (i == 1)
                    {
                        pleyer1.Header = namepeople.Text;
                        i++;
                        sobes2.Text = $"Ваш собеседник: {namepeople.Text}";
                    }
                    else if (i == 2)
                    {
                        pleyer2.Header = namepeople.Text;
                        sobes1.Text = $"Ваш собеседник: {namepeople.Text}";
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Введите имя и пароль");
                }
            }
            else
            {
                MessageBox.Show("Превышен лимит пользователей");
            }
            namepeople.Text = "";
            passwordpeople.Password = "";
            checkBox1.IsChecked = false;
        }



        private void soob1_KeyUp(object sender, KeyEventArgs e)
        {
            if (soob1.Text!= "")
            {
                if (e.Key == Key.Enter)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = soob1.Text;
                    soob1.Text = "";
                    textBlock.FontSize = 20;
                    textBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    mylist1.Children.Add(textBlock);
                    soob(textBlock, 2);
                    scroll1.ScrollToEnd(); //прокручивает в самый низ при отправке сообщений
                }
            }
          
        }

        private void soob2_KeyUp(object sender, KeyEventArgs e)
        {
            if (soob2.Text != "")
            {
                if (e.Key == Key.Enter)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = soob2.Text;
                    soob2.Text = "";
                    textBlock.FontSize = 20;
                    textBlock.HorizontalAlignment = HorizontalAlignment.Right;
                    mylist2.Children.Add(textBlock);
                    soob(textBlock, 1);
                    scroll2.ScrollToEnd();
                }
            }
        }
    }
}