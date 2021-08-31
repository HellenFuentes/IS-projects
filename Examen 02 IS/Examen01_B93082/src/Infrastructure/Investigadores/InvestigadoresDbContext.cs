using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Examen01_B93082.Infrastructure.Core;
using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Infrastructure.Investigadores.EntityMappings;

namespace Examen01_B93082.Infrastructure.Investigadores
{
    public class InvestigadoresDbContext : ApplicationDbContext
    {
        public InvestigadoresDbContext(DbContextOptions<InvestigadoresDbContext> options, ILogger<InvestigadoresDbContext> logger)
          : base(options, logger)
        {
        }
        public DbSet<Investigador> Investigador { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new InvestigadoresMap());
        }
    }
}