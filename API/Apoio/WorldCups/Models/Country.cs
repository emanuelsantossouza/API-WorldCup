using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCups.Models;

[Table("Country")]
public class Country
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(400)]
    public string Flag { get; set; }

    [JsonIgnore]
    public ICollection<WorldCupCountry> WorldCups { get; set; }

    [JsonIgnore]
    public ICollection<WorldCupCountryPlayer> WorldCupPlayers { get; set; }
}
