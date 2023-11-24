using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.EntityFramework.Configuration
{
    public class CurtidaConfiguration : IEntityTypeConfiguration<Curtida>
    {
        public void Configure(EntityTypeBuilder<Curtida> builder)
        {
            builder.ToTable("CURTIDA");
            builder.HasKey(x => x.Id);

            builder.Property(nt => nt.AnimalId)
              .HasColumnName("AnimalId")
              .HasColumnType("int");

            // Configuração da propriedade IdDestino
            builder.Property(nt => nt.DestinoId)
                   .HasColumnName("DestinoId")
                   .HasColumnType("int");

            // Configuração da propriedade Curtiu
            builder.Property(nt => nt.Curtiu)
                   .HasColumnName("Curtiu")
                   .HasColumnType("bit");
        }
    }
}
