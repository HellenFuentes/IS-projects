using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Examen01_B93082.Infrastructure.Core;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Examen01_B93082.Infrastructure.GruposInvestigacion.EntityMappings;

namespace Examen01_B93082.Infrastructure.GruposInvestigacion
{
    public class GrupoInvestigacionDbContext : ApplicationDbContext
    {
        public GrupoInvestigacionDbContext(DbContextOptions<GrupoInvestigacionDbContext> options, ILogger<GrupoInvestigacionDbContext> logger)
         : base(options, logger)
        {
        }
        public DbSet<GrupoInvestigacion> GrupoInvestigacion { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GrupoInvestigadoresMap());
        }
    }
}
