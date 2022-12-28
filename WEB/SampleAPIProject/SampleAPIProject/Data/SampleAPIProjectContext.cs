using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleAPIProject;

namespace SampleAPIProject.Data
{
    public class SampleAPIProjectContext : DbContext
    {
        public SampleAPIProjectContext (DbContextOptions<SampleAPIProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SampleAPIProject.UserCred> UserCred { get; set; } = default!;
    }
}
