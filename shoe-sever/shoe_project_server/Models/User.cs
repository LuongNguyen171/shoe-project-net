using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int userId { get; set; }
    [Required]
    public bool userRole { get; set; }

    public string userName { get; set; }
    public string userPassword { get; set; }
    public string userPhone { get; set; } 
    public string userAddress { get; set; }
    public string userEmail { get; set; }

}
