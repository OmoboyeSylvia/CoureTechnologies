using System.ComponentModel.DataAnnotations;

namespace CoureTechnologies.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

    }
}
