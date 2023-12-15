using System.ComponentModel.DataAnnotations;

namespace shoe_project_server.Models
{
    public class ProductImage
    {
        [Key]
        public int productImageId { get; set; }
        public int producId { get; set; }
        public string productImage { get; set; }
    }
}
