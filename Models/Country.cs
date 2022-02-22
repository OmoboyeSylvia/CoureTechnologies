using System.ComponentModel.DataAnnotations;

namespace CoureTechnologies.Models
{
    public class Country
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? CountryCode { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? CountryIso { get; set; }
    }
}
