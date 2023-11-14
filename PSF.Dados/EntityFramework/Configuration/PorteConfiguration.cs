using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PSF.Dados.EntityFramework.Configuration
{
    public class PorteConfiguration : IEntityTypeConfiguration<Porte>
    {
        public void Configure(EntityTypeBuilder<Porte> builder)
        {
            builder.ToTable("PORTE");
            builder.HasKey(x => x.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("Id")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Tamanho)
                .HasColumnName("TAMANHO")
                .HasColumnType("decimal(15)")
                ;
            builder
               .Property(x => x.Sigla)
               .HasColumnName("SIGLA")
               .HasColumnType("char")
               ;
        }
    }
}
