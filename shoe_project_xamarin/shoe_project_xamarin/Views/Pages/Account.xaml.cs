using Newtonsoft.Json;
using shoe_project_xamarin.Models;
using System;
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
using shoe_project_xamarin.Views.MyPopup;
using Xamarin.CommunityToolkit.Extensions;
using Acr.UserDialogs;

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

            /* List<Order> orders = new List<Order>()
             {
                 new Order() {orderId = 1, orderStatus = "Hoàn thành", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
                 new Order() {orderId = 2, orderStatus = "Đang giao", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
                 new Order() {orderId = 3, orderStatus = "Đang giao", orderDate = new DateTime(), deliveryDate  = new DateTime(), customerPhone = "123456"},
             };
             HistoryOrder.ItemsSource = orders;*/

            List<Product> products = new List<Product>()
            {
                new Product() { productId = 1, producerId = 1, productName = "Nike Air Force 1", productPrice = 2300000, productDescribe = "Basketball", productImage = "shoeimg.jpg"},
                new Product() { productId = 2, producerId = 1, productName = "Nike Air Force 2", productPrice = 3000000, productDescribe = "Basketball", productImage = "shoeimg2.jpg"},
                new Product() { productId = 3, producerId = 1, productName = "Nike Air Force 3", productPrice = 3500000, productDescribe = "Basketball", productImage = "shoeimg.jpg"},
            };
            shippingOrder.ItemsSource = products;
        }
        //get user infor
        private async void GetUserInfor()
        {
            string accessToken = SecureStorage.GetAsync("AccessToken").Result;
            try
            {

                if (!string.IsNullOrEmpty(accessToken))
                {
                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost("/auth/GetUserInfo");

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                        UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                        var response = await client.GetAsync(apiUrl);
                        UserDialogs.Instance.HideLoading();

                        if (response.IsSuccessStatusCode)
                        {

                            var content = await response.Content.ReadAsStringAsync();
                            var userInfo = JsonConvert.DeserializeAnonymousType(content, new
                            {
                                id = string.Empty,
                                userName = string.Empty,
                                userEmail = string.Empty
                            });
                            mainContentLayout.IsVisible = true;
                            noDataLabel.IsVisible = false;

                            lblUserName.Text = userInfo.userName;
                            lblEmail.Text = userInfo.userEmail;
                        }
                        else
                        {
                            mainContentLayout.IsVisible = false;
                            noDataLabel.IsVisible = true;
                        }
                    }
                }
                else
                {
                    mainContentLayout.IsVisible = false;
                    noDataLabel.IsVisible = true;
                }
            }
            catch (Exception ex)
            {

                mainContentLayout.IsVisible = false;
                noDataLabel.IsVisible = true;
                DisplayAlert("user!", $"{ex.Message}", "OK");

            }
        }
        //get order by user

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


                        UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                        var response = await client.GetAsync(apiUrl);
                        UserDialogs.Instance.HideLoading();


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
                            Console.WriteLine("Error!", "Failed to retrieve orders.", "OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!", $"An error occurred: {ex.Message}", "OK");
            }

            return null;
        }
        //get order detail

        private async Task<OrderDetail> GetOrderDetailAsync(int orderId)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    string apiUrl = apiSettings.BuildApiClientHost($"/order/orderDetail/{orderId}");

                    UserDialogs.Instance.ShowLoading("Loading Please Wait...");
                    var response = await client.GetAsync(apiUrl);
                    UserDialogs.Instance.HideLoading();


                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var orderDetail = JsonConvert.DeserializeObject<OrderDetail>(content);


                        return orderDetail;
                    }
                    else
                    {
                        Console.WriteLine($"Failed to retrieve order detail. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null;
        }
        // handle click list view item

        private void OnHistoryOrderItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is CustomOrderResponse selectedOrder)
            {
                int orderId = selectedOrder.orderId;

                HandleShowPopup(orderId);
            }

            ((ListView)sender).SelectedItem = null;
        }

        private async void HandleShowPopup(int orderId)
        {
            try
            {
                OrderDetail orderDetails = await GetOrderDetailAsync(orderId);
                if (orderDetails != null)
                {
                    Navigation.ShowPopup(new OrderPlacedDetailPopup(orderDetails.productDetails, orderDetails.paymentInvoice));
                }
                else
                {
                    Console.WriteLine("Failed to retrieve order details.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


        }

        private void logout_btn_Clicked(object sender, EventArgs e)
        {
            try
            {
                SecureStorage.Remove("AccessToken");
                SecureStorage.Remove("UserId");
                Navigation.PushModalAsync(new Login());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error!", $"Cannot log out: {ex.Message}", "OK");
            }
        }
    }
}