using System.ComponentModel.DataAnnotations;

namespace JWTTokenWebAPI.Controllers
{
    public class UserCredentials
    {
        [Key]
        public int id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
