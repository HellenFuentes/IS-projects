using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Examen01_B93082.Infrastructure.Core;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;
using Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion.EntityMappings;

namespace Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion
{
    public class ParticipaGrupoInvestigacionDbContext : ApplicationDbContext
    {
        public ParticipaGrupoInvestigacionDbContext(DbContextOptions<ParticipaGrupoInvestigacionDbContext> options,
            ILogger<ParticipaGrupoInvestigacionDbContext> logger)
          : base(options, logger)
        {
        }
        public DbSet<ParticipaGrupoInvestigacion> ParticipaGrupoInvestigacion { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ParticipaGrupoInvestigacionMap());
        }
    }
}
