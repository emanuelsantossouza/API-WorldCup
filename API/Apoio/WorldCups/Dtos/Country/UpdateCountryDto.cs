using System.ComponentModel.DataAnnotations;

namespace WorldCups.Dtos.Country;

public class UpdateCountryDto
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(400)]
    public string Flag { get; set; }
}
