using shoe_project_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.MyPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPopup : Popup
    {
        public OrderPopup()
        {
            InitializeComponent();

           
        }

    }
}