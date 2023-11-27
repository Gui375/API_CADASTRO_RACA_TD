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
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Curtida> Curtida { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93,1434; 
                                    Database = BD044748; 
                                    User ID = RA044748; 
                                    Password = 044748;
                                    TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RacaConfiguration());
            modelBuilder.ApplyConfiguration(new PorteConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new CurtidaConfiguration());
            modelBuilder.ApplyConfiguration(new MensagemConfiguration());

        }


    }
}
