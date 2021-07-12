using HealthyAPI.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.ApplicationContext
{
    public class HealthContext: DbContext
    {
        public HealthContext(DbContextOptions<HealthContext> options): base(options)
        {

        }

        public DbSet<MoneyTaker> moneyTakers { get; set; }
        public DbSet<MoneyPlacement> MoneyPlacement { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           // builder.Entity<MoneyTaker>(x => x.)
            
        }
    }
}
