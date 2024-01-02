namespace shoe_project_server.Models.DTOs
{
    public class OrderDetailModel
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string ProducerName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
