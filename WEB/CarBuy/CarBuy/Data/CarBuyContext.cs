using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBuy.Models;

namespace CarBuy.Data
{
    public class CarBuyContext : DbContext
    {
        public CarBuyContext (DbContextOptions<CarBuyContext> options)
            : base(options)
        {
        }

        public DbSet<CarBuy.Models.Card> Card { get; set; } = default!;
    }
}
