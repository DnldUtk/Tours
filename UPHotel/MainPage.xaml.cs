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

namespace UPHotel
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToursButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MngrMainFrame.Navigate(new ToursPage());
        }
    
        private void HotelsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MngrMainFrame.Navigate(new HotelPage());
        }
    }
}
