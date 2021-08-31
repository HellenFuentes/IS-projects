using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Examen01_B93082.Infrastructure.Core;
using Examen01_B93082.Domain.Autores.Entities;
using Examen01_B93082.Infrastructure.Autores.EntityMappings;


namespace Examen01_B93082.Infrastructure.Autores
{
    public class AutoresDbContext : ApplicationDbContext
    {
        public AutoresDbContext(DbContextOptions<AutoresDbContext> options, ILogger<AutoresDbContext> logger)
           : base(options, logger)
        {
        }
        public DbSet<Autor> Autor { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AutoresMap());
        }
    }
}
