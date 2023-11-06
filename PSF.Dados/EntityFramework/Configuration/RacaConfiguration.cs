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
    public class RacaConfiguration : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("RACA");
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("ID_RACA")
                .HasColumnType("int");

            builder
                .Property(f => f.NomeRaca)
                .HasColumnName("NOME_RACA")
                .HasColumnType("varchar(40)");

            builder
                .Property(f => f.Tamanho)
                .HasColumnName("TAMANHO")
                .HasColumnType("int");

            builder
                .Property(f => f.Porte)
                .HasColumnName("PORTE")
                .HasColumnType("char");

           

        }
    }
}
