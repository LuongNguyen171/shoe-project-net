namespace shoe_project_server.Models.DTOs
{
    public class OrderDetailsViewModel
    {
        public int orderId { get; set; }
        public string orderStatus { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public string customerPhone { get; set; }
        public string customerId { get; set; }
        public double paymentInvoice { get; set; }
        public List<ProductDetailsViewModel> productDetails { get; set; } = new List<ProductDetailsViewModel>();
    }

    public class ProductDetailsViewModel
    {
        public string productImage { get; set; }
        public int productQuantity { get; set; }
        public double productPrice { get; set; }
        public double totalPrice { get; set; }
    }

}
