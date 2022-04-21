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
using SportwearStore.EF;
using SportwearStore.ClassHelper;

namespace SportwearStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для SweatshirtWindow.xaml
    /// </summary>
    public partial class SweatshirtWindow : Window
    {
        List<Product> productList = new List<Product>();

        public SweatshirtWindow()
        {
            InitializeComponent();

            Filter();
        }

        private void Filter()
        {
            productList = AppData.Context.Product.ToList();
            productList = productList.
                            Where(i => i.NameProduct.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            lvProduct.ItemsSource = productList;
        }

        private void tbMainPage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void txtSearch_MouseUp(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Text = "";
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

        private void tbBackMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
