using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public float? MovieRetings { get; set; }

        public string? OTT { get; set; }
    }
}
