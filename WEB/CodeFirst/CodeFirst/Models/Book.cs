using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Book
    {
        [Key]
        public int BookID { get;set; }
        public string? BookTitle { get; set; }
        public string? BookAuthor { get; set; }
        public int price { get; set; }
    }
}
