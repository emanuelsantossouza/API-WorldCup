using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCups.Models;

[Table("WorldCup")]
public class WorldCup
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int CountryId { get; set; }
    public Country Country { get; set; }

    [Required]
    public ushort Year { get; set; }

    public ICollection<WorldCupCountry> Countries { get; set; }

    [JsonIgnore]
    public ICollection<WorldCupCountryPlayer> WorldCupPlayers { get; set; }
}
