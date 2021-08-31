using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Examen01_B93082.Infrastructure.Core;
using Examen01_B93082.Domain.Coordinadores.Entities;
using Examen01_B93082.Infrastructure.Coordinadores.EntityMappings;

namespace Examen01_B93082.Infrastructure.Coordinadores
{
    public class CoordinadoresDbContext : ApplicationDbContext
    {
        public CoordinadoresDbContext(DbContextOptions<CoordinadoresDbContext> options, ILogger<CoordinadoresDbContext> logger)
          : base(options, logger)
        {
        }
        public DbSet<Coordinador> Coordinador { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CoordinadoresMap());
        }
    }
}
