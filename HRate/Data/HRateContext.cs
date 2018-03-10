using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HRate.Models
{
    public class HRateContext : DbContext
    {
        public HRateContext (DbContextOptions<HRateContext> options)
            : base(options)
        {
        }

        public DbSet<HRate.Models.Movie> Movie { get; set; }
    }
}
