using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSF.Dominio.Entities;
using PSF.Dados.EntityFramework.Configuration;

namespace PSF.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        public DbSet<Raca> Raca { get; set; }

        public Contexto() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = BANDEIRA,1434; 
                                    Database = BD044748; 
                                    User ID = RA044748; 
                                    Password = 044748;
                                    TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RacaConfiguration());
        }

    }
}
