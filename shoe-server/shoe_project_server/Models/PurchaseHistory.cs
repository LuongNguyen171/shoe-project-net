using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoe_project_server.Models
{
    public class PurchaseHistory
    {
        [Key]
        public int orderId { get; set; }
        [Key]
        public string userId { get; set; }
        [Key]
        public int productId { get; set; }
        public int productQuantity { get; set; }

        [ForeignKey("productId")]
        public Product Product { get; set; }
    }
}
