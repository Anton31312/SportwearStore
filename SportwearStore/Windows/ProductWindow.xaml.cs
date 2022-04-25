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
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {

        EF.Clothes product = new EF.Clothes();

        public ProductWindow(EF.Clothes clothes)
        {
            InitializeComponent();

            product = clothes;
            //заполнение ComboBox
            cmbSize.ItemsSource = AppData.Context.Size.ToList();
            cmbSize.DisplayMemberPath = "NameSize";
            cmbSize.SelectedIndex = 0;

            tbProductName.Text = product.NameProduct;
            tbDescription.Text = product.Description;
            tbCost.Text = product.GetCost;
            tbArticul.Text = product.Articul;
            tbCollection.Text = product.Collection.NameCollection;
            tbMaterial.Text = product.Material.NameMaterial;
            tbCountry.Text = product.ManufactureCountry.NameCountry;
            tbSeason.Text = product.Season.SeasonName;
            tbStyle.Text = product.Style.StyleName;

            //добавление главного изображения
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(product.MainPhoto, UriKind.Relative);
            bi.EndInit();
            imgMainPhoto.Source = bi;

            //заполнения доп изображений
            lvPhoto.ItemsSource = product.ProductPhoto.Where(i => i.IDProduct == product.ID);
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

        private void cmbSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbSweat_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow(1);
            this.Close();
            sweatshirtWindow.Show();
        }

        private void tbRash_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow(5);
            this.Close();
            sweatshirtWindow.Show();
        }

        private void tbCycling_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow(3);
            this.Close();
            sweatshirtWindow.Show();
        }

        private void tbTop_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow(2);
            this.Close();
            sweatshirtWindow.Show();
        }

        private void tbTights_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SweatshirtWindow sweatshirtWindow = new SweatshirtWindow(4);
            this.Close();
            sweatshirtWindow.Show();
        }
    }
}
