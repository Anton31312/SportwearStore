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
using SportwearStore.Windows;

namespace SportwearStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtSearch_MouseUp(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void borderSvit_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void borderTop_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void borderBiker_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void borderTaytsi_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void borderRashgardy_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tbMainPage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnLike_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnBag_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnProfile_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
