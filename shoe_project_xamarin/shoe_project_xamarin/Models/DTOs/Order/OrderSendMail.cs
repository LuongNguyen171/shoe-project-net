using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Order
{
    public class OrderSendMail
    {
        public string userId { get; set; }
        public string orderStatus { get; set; }
        public string customerPhone { get; set; }
        public List<ProductItem> purchaseHistoryItems { get; set; }
    }

    public class ProductItem
    {
        public int productId { get; set; }
        public int productQuantity { get; set; }
    }
}
