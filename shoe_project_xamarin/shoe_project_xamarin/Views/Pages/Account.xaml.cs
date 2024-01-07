using Newtonsoft.Json;
using shoe_project_xamarin.Models;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using shoe_project_server.Models.HostConfig;
using shoe_project_xamarin.Models.DTOs.Order;
using static Android.Resource;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {
        ApiSettings apiSettings = new ApiSettings();

        public Account()
        {
            InitializeComponent();
            GetUserInfor();
            GetOrdersByCustomerIdAsync();

            List<Order> orders = new List<Order>()
             {
                 new Order() {orderId = 1, orderStatus = "Hoàn thành", orderDate = new DateTime(2024, 1, 3), deliveryDate  = new DateTime(2024, 1, 3), customerPhone = "123456"},
                 new Order() {orderId = 2, orderStatus = "Đang giao", orderDate = new DateTime(2024, 1, 3), deliveryDate  = new DateTime(2024, 1, 3), customerPhone = "123456"},
                 new Order() {orderId = 3, orderStatus = "Đang giao", orderDate = new DateTime(2024, 1, 3), deliveryDate  = new DateTime(2024, 1, 3), customerPhone = "123456"},
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
        private async void GetUserInfor()
        {
            try
            {
                string accessToken = SecureStorage.GetAsync("AccessToken").Result;

                if (!string.IsNullOrEmpty(accessToken))
                {
                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost("/auth/GetUserInfo");

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                        var response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            var userInfo = JsonConvert.DeserializeAnonymousType(content, new
                            {
                                id = string.Empty,
                                userName = string.Empty,
                                userEmail = string.Empty
                            });

                            lblUserName.Text = userInfo.userName;
                            lblEmail.Text = userInfo.userEmail;
                        }
                        else
                        {
                            lblUserName.Text = "Không có dữ liệu";
                            lblEmail.Text = "Không có dữ liệu";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                lblUserName.Text = "Không có dữ liệu";
                lblEmail.Text = "Không có dữ liệu";
                DisplayAlert("user!", $"{ex.Message}", "OK");

            }
        }

        private async Task<List<Order>> GetOrdersByCustomerIdAsync()
        {
            try
            {
                string accessToken = SecureStorage.GetAsync("AccessToken").Result;
                string customerId = SecureStorage.GetAsync("UserId").Result;

                if (!string.IsNullOrEmpty(accessToken) && !string.IsNullOrEmpty(customerId))
                {
                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost($"/order/getOrderByCustomer/{customerId}");


                        var response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            var originalOrders = JsonConvert.DeserializeObject<List<Order>>(content);

                            var customOrders = originalOrders.Select(o => new CustomOrderResponse
                            {
                                orderId = o.orderId,
                                orderStatus = o.orderStatus,
                                orderDate = o.orderDate.ToString("dd-MM-yyyy"),
                                deliveryDate = o.deliveryDate.ToString("dd-MM-yyyy"),
                                customerPhone = o.customerPhone,
                                customerId = o.customerId
                            }).ToList();

                            HistoryOrder.ItemsSource = customOrders;
                        }
                        else
                        {
                            DisplayAlert("Error!", "Failed to retrieve orders.", "OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error!", $"An error occurred: {ex.Message}", "OK");
            }

            return null;
        }


    }
}