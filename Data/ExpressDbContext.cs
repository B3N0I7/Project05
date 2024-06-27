using Express.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Express.Data
{
    public class ExpressDbContext : IdentityDbContext
    {
        public ExpressDbContext(DbContextOptions<ExpressDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Inventaire> Inventaires { get; set; }
        public DbSet<Reparation> Reparations { get; set; }
    }
}