using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {
        public Account()
        {
            InitializeComponent();

            List<Order> orders = new List<Order>()
            {
                new Order() {orderId = 1, orderStatus = "Hoàn thành", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
                new Order() {orderId = 2, orderStatus = "Đang giao", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
                new Order() {orderId = 3, orderStatus = "Đang giao", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
            };
            HistoryOrder.ItemsSource = orders;

            List<Product> products = new List<Product>()
            {
                new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg"},
                new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, ProductDescribe = "Basketball", productImage = "shoeimg2.jpg"},
                new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, ProductDescribe = "Basketball", productImage = "shoeimg.jpg"},
            };
            shippingOrder.ItemsSource = products;
        }
    }
}