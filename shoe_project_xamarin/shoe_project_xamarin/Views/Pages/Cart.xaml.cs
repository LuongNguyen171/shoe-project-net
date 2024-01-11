using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using shoe_project_xamarin.Models;
using shoe_project_xamarin.Models.DTOs.Cart;
using shoe_project_xamarin.Views.MyPopup;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        private decimal totalPrice;
        private decimal deliveryFee;
        private decimal sumTotalPrice;

        public Cart()
        {
            InitializeComponent();
            ShowCart();
        }

        public async void ShowCart()
        {
            string cartData = await SecureStorage.GetAsync("cart");
            if (!string.IsNullOrEmpty(cartData))
            {
                List<CartItem> cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartData);

                totalPrice = cartItems.Sum(item => item.totalPriceItem);
                deliveryFee = 100000;
                sumTotalPrice = totalPrice + deliveryFee;

                string formattedTotalPrice = string.Format("{0:C0}", totalPrice);
                string formatteddeliveryFee = string.Format("{0:C0}", deliveryFee);
                string formattedsumTotalPrice = string.Format("{0:C0}", sumTotalPrice);

                totalPriceLabel.Text = formattedTotalPrice;
                deliveryFeeLabel.Text = formatteddeliveryFee;
                sumTotalPriceLabel.Text = formattedsumTotalPrice;

                /* StringBuilder cartInfo = new StringBuilder("Cart Items:\n");
                 foreach (CartItem item in cartItems)
                 {
                     cartInfo.AppendLine($"{item.productName}, Quantity: {item.quantity}");
                 }
                 await DisplayAlert("Cart Information", cartInfo.ToString(), "OK");

 */
                listImg.ItemsSource = cartItems;

            }
            else
            {
                await DisplayAlert("Cart Information", "Your cart is empty.", "OK");
            }
        }
        private void RemoveItemFromCart(int productId)
        {
            string cartData = SecureStorage.GetAsync("cart").Result;

            if (!string.IsNullOrEmpty(cartData))
            {
                List<CartItem> cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cartData);

                CartItem itemToRemove = cartItems.FirstOrDefault(item => item.productId == productId);

                if (itemToRemove != null)
                {
                    cartItems.Remove(itemToRemove);

                    string updatedCartData = JsonConvert.SerializeObject(cartItems);
                    SecureStorage.SetAsync("cart", updatedCartData);

                    listImg.ItemsSource = cartItems;
                }
            }
        }

        private async void ShowPopupCheckout(object sender, EventArgs e)
        {
           

            await PopupNavigation.Instance.PushAsync(new PopupCheckout());
           
        }

        private void delete_icon_Tapped(object sender, EventArgs e)
        {
            if (sender is Image deleteIcon)
            {
                if (deleteIcon.BindingContext is CartItem cartItem)
                {
                    int productId = cartItem.productId;

                    RemoveItemFromCart(productId);
                    ShowCart();
                }
            }
        }
    }
}