using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ApplicationDbContext : DbContext 
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        { }
        public DbSet <Banco> Bancos { get; set; }
        public DbSet<BancoAgencia> BancoAgencias { get; set; }
        public DbSet<BancoContaCaixa> BancoContaCaixas { get; set; }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
            Builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
