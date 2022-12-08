using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCups.Models;

[Table("Player")]
public class Player
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [DataType(DataType.Date)]
    public DateTime Birth { get; set; }
    
    [JsonIgnore]
    public ICollection<WorldCupCountryPlayer> WorldCupPlayers { get; set; }
}
