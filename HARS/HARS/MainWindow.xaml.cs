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
using static HARS.DAO.LoginDAO;
using HARS.Models;

namespace HARS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef = this;
            App.loginPage = new LoginPage();
            App.dashboard = new Dashboard();


            ParentFrame.Navigate(App.loginPage);
        }
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Logout(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(App.loginPage);
            App.loginPage.usernameInput.Text = string.Empty;
            App.loginPage.passwordInput.Password = string.Empty;
            App.ParentWindowRef.LogoutButton.Visibility = Visibility.Collapsed;
            User.LogoutUser(App.user);
        }
        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
