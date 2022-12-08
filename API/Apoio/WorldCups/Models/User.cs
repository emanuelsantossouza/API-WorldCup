using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCups.Models;

[Table("User")]
public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(20)]
    public string UserName { get; set; }
    
    [Required]
    public byte[] PasswordHash { get; set; }
    
    [Required]
    public byte[] PasswordSalt { get; set; }
}
