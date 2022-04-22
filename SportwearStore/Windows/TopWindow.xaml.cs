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
using System.Windows.Shapes;

namespace SportwearStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для TopWindow.xaml
    /// </summary>
    public partial class TopWindow : Window
    {
        public TopWindow()
        {
            InitializeComponent();
        }

        private void tbMainPage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void txtSearch_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
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

        private void tbSweat_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow();
            this.Close();
            sweatshirtWindow.Show();
        }

        private void tbRash_MouseUp(object sender, MouseButtonEventArgs e)
        {
            RaschgardWindow raschgardWindow = new RaschgardWindow();
            this.Close();
            raschgardWindow.Show();
        }

        private void tbCycling_MouseUp(object sender, MouseButtonEventArgs e)
        {
            CyclingShortsWindow cyclingShortsWindow = new CyclingShortsWindow();
            this.Close();
            cyclingShortsWindow.Show();
        }

        private void tbTights_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TightsWindow tightsWindow = new TightsWindow();
            this.Close();
            tightsWindow.Show();
        }
    }
}
