using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen01_B93082.Infrastructure.GruposInvestigacion.EntityMappings
{
    public class GrupoInvestigadoresMap : IEntityTypeConfiguration<GrupoInvestigacion>
    {
        public void Configure(EntityTypeBuilder<GrupoInvestigacion> builder)
        {
            builder.ToTable("GrupoInvestigacion");
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Nombre)
                .HasColumnName("Nombre")
                .IsRequired();
            builder.Property(g => g.Descripcion)
                .HasColumnName("Descripcion");
            builder.Property(g => g.FechaCreacion)
                .HasColumnName("FechaCreacion")
                .IsRequired();
            builder.Property(g => g.Coordinador)
                .HasColumnName("Coordinador");
        }
    }
}
