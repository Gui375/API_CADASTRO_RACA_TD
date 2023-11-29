using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSF.Dominio.Entities;

namespace PSF.Dados.EntityFramework.Configuration
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            // Nome da tabela
            builder.ToTable("MATCH");

            // Chave primária composta
            builder.HasKey(x => x.Id);

            // Relacionamento com a tabela Curtida
            builder.HasMany(m => m.Mensagens)
                .WithOne(m => m.Match)
                .HasForeignKey(m => m.MatchId)
                .IsRequired();


        }
    }
}
