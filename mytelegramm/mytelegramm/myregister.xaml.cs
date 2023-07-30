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
    /// Логика взаимодействия для myregister.xaml
    /// </summary>
    public partial class myregister : Page
    {
        public myregister()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            // Получаем ссылку на родительское окно (MainWindow)
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            // Получаем ссылку на Frame
            Frame myFrame = (Frame)mainWindow.FindName("NavigationFrame");
            myFrame.Content = new mychat();
        }

  
    }
}
