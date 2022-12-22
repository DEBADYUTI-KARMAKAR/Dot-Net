using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWTTokenWebAPI.Controllers;

namespace JWTTokenWebAPI.Data
{
    public class JWTTokenWebAPIContext : DbContext
    {
        public JWTTokenWebAPIContext (DbContextOptions<JWTTokenWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<JWTTokenWebAPI.Controllers.UserCredentials> UserCredentials { get; set; } = default!;
    }
}
