using System.ComponentModel.DataAnnotations;

namespace shoe_project_server.Models
{
    public class PurchaseHistory
    {
        [Key]
        public int orderId { get; set; }
        [Key]
        public int userId { get; set; }
        public int productId { get; set; }
        public int productQuantity { get; set; }
    }
}
