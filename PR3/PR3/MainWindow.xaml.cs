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

namespace PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public List<Product> Products {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Products = new List<Product>();
            ProductsDataGrid.ItemsSource = Products;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string productName = ProductNameTextBox.Text;
            string productPrice = ProductPriceTextBox.Text;
            string productQuantity = ProductQuantityTextBox.Text;

            Products.Add(new Product
            {
                ProductName = productName,
                ProductPrice = productPrice,
                ProductQuantity = productQuantity,
            });

            ProductNameTextBox.Clear();
            ProductPriceTextBox.Clear();
            ProductQuantityTextBox.Clear();
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
    }
}


