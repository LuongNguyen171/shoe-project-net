using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shoe_project_xamarin.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();

            List<Product> products = new List<Product>()
            {
                new Product {productId = 1,productImage = "shoeimg.jpg", productName = "Nike Air Force 1"},
                new Product {productId = 2,productImage = "shoeimg2.jpg", productName = "Nike Air Force 2"},
                new Product {productId = 3,productImage = "shoesImage.jpg", productName = "Nike Air Force 3"},
                new Product {productId = 4,productImage = "shoeimg.jpg", productName = "Nike Air Force 4"},
            };

            listImg.ItemsSource = products;
        }
    }
}