using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCups.Models;

[Table("WorldCupCountryPlayer")]
public class WorldCupCountryPlayer
{
    [Key, Column(Order = 1)]
    public int WorldCupId { get; set; }
    public WorldCup WorldCup { get; set; }

    [Key, Column(Order = 2)]
    public int CountryId { get; set; }
    public Country Country { get; set; }

    [Key, Column(Order = 3)]
    public int PlayerId { get; set; }
    public Player Player { get; set; }
}
