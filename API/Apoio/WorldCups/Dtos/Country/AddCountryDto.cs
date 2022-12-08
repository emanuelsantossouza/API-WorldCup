using System.ComponentModel.DataAnnotations;

namespace WorldCups.Dtos.Country;

public class AddCountryDto
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(400)]
    public string Flag { get; set; }
}
