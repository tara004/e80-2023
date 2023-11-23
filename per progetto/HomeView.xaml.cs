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

namespace ProjectWork_E80_2023.Views
{
    /// <summary>
    /// Logica di interazione per HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientView());
        }

        private void Transports_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TransportView());
        }

        private void Veichles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VeichleView());
        }

        private void Page_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
