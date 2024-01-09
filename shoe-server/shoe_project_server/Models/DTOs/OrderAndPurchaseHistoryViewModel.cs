namespace shoe_project_server.Models.DTOs
{
    public class OrderAndPurchaseHistoryViewModel
    {
        public string userId { get; set; }
        public string orderStatus { get; set; }
        public string customerPhone { get; set; }
        public List<PurchaseHistoryItem> purchaseHistoryItems { get; set; }
    }

    public class PurchaseHistoryItem
    {
        public int productId { get; set; }
        public int productQuantity { get; set; }
    }
}
