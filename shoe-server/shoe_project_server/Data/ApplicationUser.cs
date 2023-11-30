using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace shoe_project_server.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public bool UserRole { get; set; } = false;
      
    }
}
