using Newtonsoft.Json;
using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Toast;
using Newtonsoft.Json.Serialization;
using static System.Net.WebRequestMethods;
using shoe_project_server.Models.HostConfig;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        bool isOpen = false;
       ApiSettings apiSettings = new ApiSettings();

        public Register()
        {
            InitializeComponent();
        }
        private void LabelSignIn_Tapped(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            NavigationPage navigationPage = new NavigationPage(loginPage);
            App.Current.MainPage = navigationPage;

        }

        private async void BtnRegister_Clicked(object sender, EventArgs e)

        {
          
            string userName = EntryUserName.Text;
            string userEmail = EntryEmail.Text;
            string userPassword = EntryPassword.Text;
            try
            {
                if (userName != null && userEmail != null && userPassword != null)
                {
                    var registerData = new
                    {
                        userName = userName,
                        userEmail = userEmail,
                        userPassword = userPassword
                    };

                    var jsonRegisterData = JsonConvert.SerializeObject(registerData);

                    using (var client = new HttpClient())
                    {
                        string apiUrl = apiSettings.BuildApiClientHost("/auth/register");

                        var content = new StringContent(jsonRegisterData, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync(apiUrl, content);

                        if (response != null)
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                await DisplayAlert("Thông báo", "Đăng ký thành công!", "ok");
                            }
                            else
                            {
                                var errorContent = await response.Content.ReadAsStringAsync();
                                await DisplayAlert("Thông báo",  $"Đăng nhập thất bại! {response.RequestMessage}", "ok");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Thông báo", "Đăng ký thất bại! Phản hồi trống.", "ok");
                        }
                    }
                }
                else
                {
                    await DisplayAlert("Thông báo", "Lỗi đối tượng Entry.", "ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Thông báo", $"Đăng ký thất bại! Lỗi kết nối: {ex.Message}", "ok");
            }
        }




        private void EyePassword_Tapped(object sender, EventArgs e)
        {
            Image imageSender = (Image)sender;
            if (isOpen)
            {
                imageSender.Source = "https://static-00.iconduck.com/assets.00/eye-password-hide-icon-2048x2048-c8pmhg0p.png";
                EntryPassword.IsPassword = true;
                isOpen = false;
            }
            else
            {
                imageSender.Source = "https://cdn-icons-png.flaticon.com/512/65/65000.png";
                EntryPassword.IsPassword = false;
                isOpen = true;

            }
        }
    }
}