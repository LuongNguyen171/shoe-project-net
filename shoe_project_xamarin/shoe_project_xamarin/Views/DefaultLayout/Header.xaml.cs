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
            Login loginPage = new Login();
            NavigationPage navigationPage = new NavigationPage(loginPage);
            App.Current.MainPage = navigationPage;
        }

       
    }
}