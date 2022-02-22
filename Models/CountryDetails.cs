using System.ComponentModel.DataAnnotations;

namespace CoureTechnologies.Models
{
    public class CountryDetails
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public string? Operator { get; set; }

        [Required]
        public string? OperatorCode { get; set; }
    }
}
