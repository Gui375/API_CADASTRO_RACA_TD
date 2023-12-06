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
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Curtida> Curtida { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Match> Match { get; set; }




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

            modelBuilder.Entity<Animal>()
             .HasOne(s => s.Raca)
             .WithMany()
             .HasForeignKey(s => s.RacaId);

            modelBuilder.Entity<Animal>()
                .HasOne(s => s.Porte)
                .WithMany()
                .HasForeignKey(s => s.PorteId);

            modelBuilder.Entity<Animal>()
                .HasOne(s => s.Usuario)
                .WithMany()
                .HasForeignKey(s => s.UsuarioId);

            modelBuilder.Entity<Animal>()
                .HasMany(s => s.Curtida)
                .WithOne()
                .HasForeignKey(c => c.Id);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Animais)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UsuarioId);

            base.OnModelCreating(modelBuilder);

        }


    }
}