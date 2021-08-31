using Examen01_B93082.Domain.Coordinadores.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen01_B93082.Infrastructure.Coordinadores.EntityMappings
{
    public class CoordinadoresMap : IEntityTypeConfiguration<Coordinador>
    {
        public void Configure(EntityTypeBuilder<Coordinador> builder)
        {
            builder.ToTable("Coordinador");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre")
                .IsRequired();
            builder.Property(a => a.FechaInicioNombramiento)
                .HasColumnName("FechaInicioNombramiento")
                .IsRequired();
            builder.Property(a => a.FechaFinalNombramiento)
                .HasColumnName("FechaFinalNombramiento");
        }
    }
}
