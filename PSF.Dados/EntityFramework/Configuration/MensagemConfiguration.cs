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
                .HasColumnName("ID_MENS")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Conteudo)
                .HasColumnName("MENSAGEM")
                .HasColumnType("varchar(1000)")
                ;
            builder
               .Property(x => x.UsuarioId1)
               .HasColumnName("ID_ENVIADO")
               .HasColumnType("int")
               ;

            builder
               .Property(x => x.UsuarioId2)
               .HasColumnName("ID_RECEBIDO")
               .HasColumnType("int")
               ;
            builder
               .Property(x => x.MatchId)
               .HasColumnName("ID_MATCH")
               .HasColumnType("int")
               ;

        }
    }
}
