using Examen01_B93082.Domain.Investigadores.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Examen01_B93082.Infrastructure.Investigadores.EntityMappings
{
    public class InvestigadoresMap : IEntityTypeConfiguration<Investigador>
    {
        public void Configure(EntityTypeBuilder<Investigador> builder)
        {
            builder.ToTable("Investigador");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre")
                .IsRequired();
            builder.Property(a => a.MaximoGrado)
                .HasColumnName("MaximoGrado");
        }
    }
}