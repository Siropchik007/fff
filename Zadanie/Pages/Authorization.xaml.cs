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

namespace Zadanie.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        
        public Authorization()
        {
            InitializeComponent();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            
            if(login.Text == "admin" & password.Text == "admin")
            {
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                mainWindow.FrmMain.Navigate(new Pages.Client());
            }
            else
            {
                MessageBox.Show("Неверные данные", "Попробуйте ещё раз", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
