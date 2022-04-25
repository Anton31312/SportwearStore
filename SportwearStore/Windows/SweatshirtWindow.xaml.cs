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
        List<Clothes> productList = new List<Clothes>();

        public SweatshirtWindow(int product)
        {
            InitializeComponent();
            if (product == 1)
            {
                tbSweat.TextDecorations = TextDecorations.Underline;
                tbNameProduct.Text = "Свитшоты";
                tbTights.TextDecorations = null;
                tbTop.TextDecorations = null;
                tbRash.TextDecorations = null;
                tbCycling.TextDecorations = null;
                productList = AppData.Context.Clothes.ToList();
                lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("Свитшот"));
            }
            if (product == 2)
            {
                tbTop.TextDecorations = TextDecorations.Underline;
                tbNameProduct.Text = "Топы";
                tbSweat.TextDecorations = null;
                tbRash.TextDecorations = null;
                tbTights.TextDecorations = null;
                tbCycling.TextDecorations = null;
                productList = AppData.Context.Clothes.ToList();
                lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("топ"));
            }
            if (product ==  3)
            {
                tbCycling.TextDecorations = TextDecorations.Underline;
                tbNameProduct.Text = "Велосипедки";
                tbSweat.TextDecorations = null;
                tbTop.TextDecorations = null;
                tbTights.TextDecorations = null;
                tbRash.TextDecorations = null;
                productList = AppData.Context.Clothes.ToList();
                lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("велосипедки") || i.NameProduct.Contains("Велосипедки"));
            }
            if (product == 4)
            {
                tbTights.TextDecorations = TextDecorations.Underline;
                tbNameProduct.Text = "Тайсты";
                tbSweat.TextDecorations = null;
                tbTop.TextDecorations = null;
                tbRash.TextDecorations = null;
                tbCycling.TextDecorations = null;
                productList = AppData.Context.Clothes.ToList();
                lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("Тайтсы") || i.NameProduct.Contains("тайтсы"));
            }
            if (product == 5)
            {
                tbRash.TextDecorations = TextDecorations.Underline;
                tbNameProduct.Text = "Рашгарды";
                tbSweat.TextDecorations = null;
                tbTop.TextDecorations = null;
                tbTights.TextDecorations = null;
                tbCycling.TextDecorations = null;
                productList = AppData.Context.Clothes.ToList();
                lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("рашгард"));
            }
        }

        private void Filter()
        {
            productList = AppData.Context.Clothes.ToList();
            //productList = productList.
            //                Where(i => i.NameProduct.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("Свитшот"));
        }

        private void tbMainPage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void txtSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {

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

        private void tbRash_MouseUp(object sender, MouseButtonEventArgs e)
        {
            tbRash.TextDecorations = TextDecorations.Underline;
            tbNameProduct.Text = "Рашгарды";
            tbSweat.TextDecorations = null;
            tbTop.TextDecorations = null;
            tbTights.TextDecorations = null;
            tbCycling.TextDecorations = null;
            productList = AppData.Context.Clothes.ToList();
            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("рашгард"));
        }

        private void tbCycling_MouseUp(object sender, MouseButtonEventArgs e)
        {
            tbCycling.TextDecorations = TextDecorations.Underline;
            tbNameProduct.Text = "Велосипедки";
            tbSweat.TextDecorations = null;
            tbTop.TextDecorations = null;
            tbTights.TextDecorations = null;
            tbRash.TextDecorations = null;
            productList = AppData.Context.Clothes.ToList();
            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("велосипедки") || i.NameProduct.Contains("Велосипедки"));
        }

        private void tbTop_MouseUp(object sender, MouseButtonEventArgs e)
        {
            tbTop.TextDecorations = TextDecorations.Underline;
            tbNameProduct.Text = "Топы";
            tbSweat.TextDecorations = null;
            tbRash.TextDecorations = null;
            tbTights.TextDecorations = null;
            tbCycling.TextDecorations = null;
            productList = AppData.Context.Clothes.ToList();
            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("топ"));
        }

        private void tbTights_MouseUp(object sender, MouseButtonEventArgs e)
        {
            tbTights.TextDecorations = TextDecorations.Underline;
            tbNameProduct.Text = "Тайсты";
            tbSweat.TextDecorations = null;
            tbTop.TextDecorations = null;
            tbRash.TextDecorations = null;
            tbCycling.TextDecorations = null;
            productList = AppData.Context.Clothes.ToList();
            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("Тайтсы") || i.NameProduct.Contains("тайтсы"));
        }

        private void tbSweat_MouseUp(object sender, MouseButtonEventArgs e)
        {
            tbSweat.TextDecorations = TextDecorations.Underline;
            tbNameProduct.Text = "Свитшоты";
            tbTights.TextDecorations = null;
            tbTop.TextDecorations = null;
            tbRash.TextDecorations = null;
            tbCycling.TextDecorations = null;
            productList = AppData.Context.Clothes.ToList();
            lvProduct.ItemsSource = productList.Where(i => i.NameProduct.Contains("Свитшот"));
        }

        private void lvProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var choiseProduct = new EF.Clothes();

            if (lvProduct.SelectedItem is EF.Clothes)
            {
                choiseProduct = lvProduct.SelectedItem as EF.Clothes;
                ProductWindow productWindow = new ProductWindow(choiseProduct);
                this.Close();
                productWindow.Show();
            }
        }
    }
}
