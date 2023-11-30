using System.ComponentModel.DataAnnotations;

namespace shoe_project_server.Models.DTOs
{
    public class RegisterModel
    {
        [Required]
        public string userName { get; set; } = null!;
        [Required,EmailAddress]
        public string userEmail { get; set; } = null!;
        [Required]
        public string userPassword { get; set; } = null!;
    }
}
