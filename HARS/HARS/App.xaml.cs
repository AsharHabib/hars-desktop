using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using HARS.Models;
using HARS.Pages;

namespace HARS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow? ParentWindowRef;
        public static LoginPage? loginPage;
        public static Dashboard? dashboard;
        public static ReservationsPage? reservationsPage;
        public static User? user;
        public static readonly HttpClient client = new HttpClient();
    }
}