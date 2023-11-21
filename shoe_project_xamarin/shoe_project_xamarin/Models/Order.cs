
using System;

namespace shoe_project_xamarin.Models
{
    public class Order
    {
      
        public int orderId { get; set; }
        public string orderStatus { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public string customerPhone { get; set; }
    }
}
