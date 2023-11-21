using System.ComponentModel.DataAnnotations;

namespace shoe_project_server.Models
{
    public class ProductDetail
    {
        [Key]
        public int productDetailId { get; set; }
        public int productId { get; set; }
        public int productSize { get; set; }
        public string productColor { get; set; }
    }
}
