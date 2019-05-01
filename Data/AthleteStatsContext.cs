using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsProj.Models
{
    public class AthleteStatsContext : DbContext
    {
        public AthleteStatsContext(DbContextOptions<AthleteStatsContext> options)
            : base(options)
        {
        }


        public DbSet<Player> Player { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Stat> Stat { get; set; }
    }
}
