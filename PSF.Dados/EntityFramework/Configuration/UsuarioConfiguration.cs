using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSF.Dominio.Entities;

namespace PSF.Dados.EntityFramework.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIOS");
            builder.HasKey(x => x.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("Id")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(255)")
                ;
            builder
               .Property(x => x.ATIVO)
               .HasColumnName("ATIVO")
               .HasColumnType("char")
               ;
            builder.HasMany(u => u.Animais)
               .WithOne(a => a.Usuario)
               .HasForeignKey(a => a.UsuarioId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
