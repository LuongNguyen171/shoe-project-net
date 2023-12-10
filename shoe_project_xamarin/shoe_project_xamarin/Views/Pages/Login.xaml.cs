using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        bool isOpen = false;

        public Login()
        {
            InitializeComponent();
        }

        async private void BtnSignIn_Clicked(object sender, EventArgs e)
        {

           

        }


        private async void LabelSignUp_Tapped(object sender, EventArgs e)
        {
            Register register = new Register();
            NavigationPage navigationPage = new NavigationPage(register);
            App.Current.MainPage = navigationPage;
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