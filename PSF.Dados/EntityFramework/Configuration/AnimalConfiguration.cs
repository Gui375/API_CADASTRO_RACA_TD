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
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("ANIMAL");
            builder.HasKey(x => x.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("Id")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(35)")
                ;
            builder
               .Property(x => x.PorteId)
               .HasColumnName("PORTEID")
               .HasColumnType("int")
               ;
            
            builder
               .Property(x => x.RacaId)
               .HasColumnName("RACAID")
               .HasColumnType("int")
               ;
            builder
               .Property(x => x.Foto)
               .HasColumnName("FOTO")
               .HasColumnType("varchar(255)")
               ;

            builder.HasOne(a => a.Porte)
              .WithMany()
              .HasForeignKey(a => a.PorteId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Raca)
                   .WithMany()
                   .HasForeignKey(a => a.RacaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Usuario)
                   .WithMany()
                   .HasForeignKey(a => a.UsuarioId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Curtida)
                    .WithOne()
                    .HasForeignKey(e => e.AnimalId)
                    .HasPrincipalKey(e => e.Id);
        }
    }
}
