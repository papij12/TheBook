using System.ComponentModel.DataAnnotations;

namespace TheBook.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        [Required]  
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }

    }
}
