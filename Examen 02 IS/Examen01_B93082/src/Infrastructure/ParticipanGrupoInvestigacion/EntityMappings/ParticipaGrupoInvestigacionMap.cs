using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion.EntityMappings
{
    public class ParticipaGrupoInvestigacionMap : IEntityTypeConfiguration<ParticipaGrupoInvestigacion>
    {
        public void Configure(EntityTypeBuilder<ParticipaGrupoInvestigacion> builder)
        {
            builder.ToTable("ParticipanGrupoInvestigacion");
            builder.HasKey(participa => new { participa.InvestigadorId, participa.GrupoInvestigacionId });
        }
    }
}
