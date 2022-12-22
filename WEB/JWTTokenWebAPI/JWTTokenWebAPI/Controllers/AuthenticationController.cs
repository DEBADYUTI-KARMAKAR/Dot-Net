using JWTTokenWebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTTokenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly JWTTokenWebAPIContext _context;
        private readonly JWTSettings _jwtSettings;

        public AuthenticationController(JWTTokenWebAPIContext context, IOptions<JWTSettings> options)

        {
            _context = context;
            _jwtSettings = options.Value;

        }


        /// <summary>
        /// Generate Token for Authorization
        /// </summary>
        [Route("CreateToken")]
        [HttpPost]

        public IActionResult CreateToken([FromBody] UserCredentials user)
        {


            var _user = _context.UserCredentials.FirstOrDefault(o => o.Username == user.Username && o.Password == user.Password);

            if (_user == null)
            {
                // return Unauthorized();
                throw new InvalidOperationException("Provide UserName and Password");

            }
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]

                {

                    new Claim(ClaimTypes.Name,_user.Username),
                }
                ),
                Expires = DateTime.Now.AddSeconds(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256)

            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            String finaltoken = tokenhandler.WriteToken(token);
            return Ok(finaltoken);
        }




    }
}
