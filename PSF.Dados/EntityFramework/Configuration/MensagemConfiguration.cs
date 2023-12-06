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
    public class MensagemConfiguration : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.ToTable("MENSAGEM");
            builder.HasKey(x => x.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Conteudo)
                .HasColumnName("CONTEUDO")
                .HasColumnType("varchar(1000)")
                ;
            builder
               .Property(x => x.Cachorro1)
               .HasColumnName("CACHORRO1")
               .HasColumnType("int")
               ;

            builder
               .Property(x => x.Cachorro2)
               .HasColumnName("CACHORRO2")
               .HasColumnType("int")
               ;
            builder
               .Property(x => x.MatchId)
               .HasColumnName("MATCHID")
               .HasColumnType("int")
               ;

        }
    }
}
