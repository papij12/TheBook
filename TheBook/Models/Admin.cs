using System.ComponentModel.DataAnnotations;

namespace TheBook.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string? AdminName { get; set; }
       
        public List<Books> Books { get; set; } = new List<Books>(); 
        public List<Clients> Clients { get; set; }= new List<Clients>();
      
    }
}
