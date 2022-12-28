using System.ComponentModel.DataAnnotations;

namespace SampleAPIProject
{
    public class UserCred
    {
        [Key]
        public int id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}
