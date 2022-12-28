using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SampleAPIProject.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SampleAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SampleAPIProjectContext _context;
        private readonly JWTSettings _jwtSettings;

        public UserController(SampleAPIProjectContext context, IOptions<JWTSettings> options)

        {
            _context = context;
            _jwtSettings = options.Value;

        }


        ///This code is generating JWT Token using username and password input
        [Route("Authenticate")]
        [HttpPost]

        public string Authenticate([FromBody] UserCred user)
        {


            var _user = _context.UserCred.FirstOrDefault(o => o.Username == user.Username && o.Password == user.Password);

            if (_user == null)
            {
                return "Unauthorized";

            }
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]

                {

                    new Claim(ClaimTypes.Name,_user.id.ToString()),
                }
                ),
                Expires = DateTime.Now.AddSeconds(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256)

            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            String finaltoken = tokenhandler.WriteToken(token);
            return finaltoken;
        }

    }
}
