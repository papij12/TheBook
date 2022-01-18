using System.ComponentModel.DataAnnotations;

namespace TheBook.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Auther { get; set; }
        [Required]
        [Display(Name ="Year of production")]
        [Range(1928,2022)]
        public int YearOfProduction { get; set; }
    }
}
