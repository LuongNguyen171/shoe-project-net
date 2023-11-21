using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoe_project_server.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        public int producerId { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public decimal productPrice { get; set; }
        public string productImage { get; set; }
        public string ProductDescribe { get; set; }
    }
}
