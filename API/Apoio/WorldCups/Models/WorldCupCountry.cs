using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCups.Models;

[Table("WorldCupCountry")]
public class WorldCupCountry
{
    [Key, Column(Order = 1)]
    public int WorldCupId { get; set; }
    public WorldCup WorldCup { get; set; }

    [Key, Column(Order = 2)]
    public int CountryId { get; set; }
    public Country Country { get; set; }

    [Required]
    [StringLength(1)]
    public string Group { get; set; }
}
