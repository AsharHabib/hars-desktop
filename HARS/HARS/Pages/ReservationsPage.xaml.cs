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
using System.Net.Http;
using HARS.Models;
using static HARS.Models.AuthToken;
using System.Net.Http.Json;

namespace HARS.Pages
{
    /// <summary>
    /// Interaction logic for ReservationsPage.xaml
    /// </summary>
    public partial class ReservationsPage : Page
    {
        public ReservationsPage()
        {
            InitializeComponent();
        }
        private async void Reservations_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("hello");
            
        }
    }
}
