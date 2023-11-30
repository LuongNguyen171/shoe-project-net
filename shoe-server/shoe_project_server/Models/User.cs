using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User: IdentityUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int userId { get; set; }
    [Required]
    public bool userRole { get; set; }
    [Required]
    public string userName { get; set; }
    [Required]
    public string userPassword { get; set; }
    [Required]
    [EmailAddress]
    public string userEmail { get; set; }
    public string userPhone { get; set; } 
    public string userAddress { get; set; }

}
