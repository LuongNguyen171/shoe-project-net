using Acr.UserDialogs;
using shoe_project_xamarin.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.DefaultLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Header : ContentView
{
    public Header()
    {
        InitializeComponent();
    }

        private void IconUser_Tapped(object sender, EventArgs e)
        {
            /* Login loginPage = new Login();
             NavigationPage navigationPage = new NavigationPage(loginPage);
             App.Current.MainPage = navigationPage;*/
            UserDialogs.Instance.ShowLoading("Loading Please Wait...");
            Navigation.PushModalAsync(new Login());
            UserDialogs.Instance.HideLoading();


        }

        private void IconCart_Tapped(object sender, EventArgs e)
        {
           
            UserDialogs.Instance.ShowLoading("Loading Please Wait...");
            Navigation.PushAsync(new Cart());

            UserDialogs.Instance.HideLoading();


        }


    }
}