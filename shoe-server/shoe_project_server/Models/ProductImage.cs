using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoe_project_server.Models
{
    public class ProductImage
    {
        [Key]
        public int productImageId { get; set; }
        public int productId { get; set; }
        public string productImage { get; set; }

        [ForeignKey("productId")]
        public Product Product { get; set; }
    }
}
