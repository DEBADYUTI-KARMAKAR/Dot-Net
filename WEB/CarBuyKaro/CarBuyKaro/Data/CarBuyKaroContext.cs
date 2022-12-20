using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBuyKaro.Models;

namespace CarBuyKaro.Data
{
    public class CarBuyKaroContext : DbContext
    {
        public CarBuyKaroContext (DbContextOptions<CarBuyKaroContext> options)
            : base(options)
        {
        }

        public DbSet<CarBuyKaro.Models.Card> Card { get; set; } = default!;
    }
}
