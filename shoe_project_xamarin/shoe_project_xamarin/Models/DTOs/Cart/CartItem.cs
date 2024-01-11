using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Cart
{
    public class CartItem
    {
        public string productImage { get; set; }
        public int productId { get; set; }
        public decimal productPrice { get; set; }
        public int quantity { get; set; }
        public string productName { get; set; }
        public decimal totalPriceItem { get; set; }
    }
}
