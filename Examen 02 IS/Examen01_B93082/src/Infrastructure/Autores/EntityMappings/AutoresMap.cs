using Examen01_B93082.Domain.Autores.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen01_B93082.Infrastructure.Autores.EntityMappings
{
    public class AutoresMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autores");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre");
            builder.Property(a => a.Apellido)
                .HasColumnName("Apellido");
        }
    }
}