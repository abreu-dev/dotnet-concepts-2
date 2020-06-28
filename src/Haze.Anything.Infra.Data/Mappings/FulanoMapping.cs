using Haze.Anything.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Haze.Anything.Infra.Data.Mappings
{
    public class FulanoMapping : IEntityTypeConfiguration<Fulano>
    {
        public void Configure(EntityTypeBuilder<Fulano> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.OwnsOne(f => f.Documento, a =>
            {
                a.Property(p => p.Numero)
                    .HasColumnName("DocumentoNumero");
                a.Property(p => p.Tipo)
                    .HasColumnName("DocumentoTipo");
            });

            builder.ToTable("Fulano");
        }
    }
}
