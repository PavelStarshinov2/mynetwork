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

namespace mytelegramm
{
    /// <summary>
    /// Логика взаимодействия для chatselected.xaml
    /// </summary>
    public partial class chatselected : Page
    {
        public chatselected()
        {
            InitializeComponent();
        }

        private void soob1_KeyUp(object sender, KeyEventArgs e) //ТУТ ВЕРНУТСЯ И СДЕЛАТЬ ВСЕ СТИЛЕМ ОДНИМ
        {
            if (soob1.Text != "")
            {
                if (e.Key == Key.Enter)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = soob1.Text;
                    soob1.Text = "";
                    // Получение ресурса стиля из App.xaml
                    Style myStyle = (Style)Application.Current.Resources["forchat"];
                    // Получение ресурса стиля из App.xaml
                    Style myStyle2 = (Style)Application.Current.Resources["forchatborder"];
                    
                    textBlock.Style = myStyle;
                    Border border = new Border();
                    border.Style = myStyle2;
                    border.Child = textBlock;
                    mylist1.Children.Add(border);
                    scroll1.ScrollToEnd(); //прокручивает в самый низ при отправке сообщений
                }
            }

        }

        private void sendsob(object sender, RoutedEventArgs e)
        {
            if (soob1.Text != "")
            {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = soob1.Text;
                    soob1.Text = "";
                    // Получение ресурса стиля из App.xaml
                    Style myStyle = (Style)Application.Current.Resources["forchat"];
                    // Получение ресурса стиля из App.xaml
                    Style myStyle2 = (Style)Application.Current.Resources["forchatborder"];

                    textBlock.Style = myStyle;
                    Border border = new Border();
                    border.Style = myStyle2;
                    border.Child = textBlock;
                    mylist1.Children.Add(border);
                    scroll1.ScrollToEnd(); //прокручивает в самый низ при отправке сообщений
            }
        }
    }
}
