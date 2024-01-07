using shoe_project_xamarin.Models.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shoe_project_xamarin.Views.MyPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPlacedDetailPopup : Popup
    {
        public OrderPlacedDetailPopup(List<ProductOrderDetail> productOrderDetail, double paymentInvoice)
        {
            InitializeComponent();
            OrderItemsListView.ItemsSource = productOrderDetail;
            PaymentInvoiceLabel.Text = $"Payment invoice: {paymentInvoice:C}";
        }
        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}