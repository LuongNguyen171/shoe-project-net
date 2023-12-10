using shoe_project_xamarin.Models;
using shoe_project_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail()
        {
            InitializeComponent();

            List<Product> products = new List<Product>()
            {
                new Product {productId = 1,productImage = "shoeimg.jpg"},
                new Product {productId = 2,productImage = "shoeimg2.jpg"},
                new Product {productId = 3,productImage = "shoesImage.jpg"},
                new Product {productId = 4,productImage = "shoeimg.jpg"},
            };

            listImg.ItemsSource = products;
        }
        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Product selectedProduct)
            {
                ImageSample.Source = selectedProduct.productImage;
            }
        }
    }
}