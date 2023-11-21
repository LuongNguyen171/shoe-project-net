using System.ComponentModel.DataAnnotations;

namespace shoe_project_server.Models
{
    public class Favourite
    {
        [Key]
        public int userId { get; set; }
        [Key]
        public int productId { get; set; }
    }
}
