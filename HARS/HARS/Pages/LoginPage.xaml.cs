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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Password;
            App.user = VerifyLoginCredentials(username, password);
            if (App.user != null)
            {
                App.ParentWindowRef.ParentFrame.Navigate(App.reservationsPage);
                App.ParentWindowRef.NavBar.Visibility = Visibility.Visible;
                App.ParentWindowRef.GreetingsLabel.Content = "Hello " + App.user.FirstName + " " + App.user.LastName + "!";
            }
            else
            {
                usernameInput.Text = string.Empty;
                passwordInput.Password = string.Empty;
                MessageBox.Show("rong username/pasword, try agane");
            }
        }

    }
}