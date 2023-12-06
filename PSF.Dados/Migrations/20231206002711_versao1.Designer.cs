﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSF.Dados.EntityFramework;

#nullable disable

namespace PSF.Dados.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231206002711_versao1")]
    partial class versao1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PSF.Dominio.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PorteId")
                        .HasColumnType("int");

                    b.Property<int>("RacaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PorteId");

                    b.HasIndex("RacaId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Curtida", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool>("Curtiu")
                        .HasColumnType("bit");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Curtida");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("Cachorro1")
                        .HasColumnType("int");

                    b.Property<int>("Cachorro2")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("Cachorro1")
                        .HasColumnType("int");

                    b.Property<int>("Cachorro2")
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Mensagem");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Porte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Portes");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Raca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("NomeRaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Raca");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Animal", b =>
                {
                    b.HasOne("PSF.Dominio.Entities.Porte", "Porte")
                        .WithMany()
                        .HasForeignKey("PorteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSF.Dominio.Entities.Raca", "Raca")
                        .WithMany()
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSF.Dominio.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSF.Dominio.Entities.Usuario", null)
                        .WithMany("Animais")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Porte");

                    b.Navigation("Raca");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Curtida", b =>
                {
                    b.HasOne("PSF.Dominio.Entities.Animal", null)
                        .WithMany("Curtida")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Match", b =>
                {
                    b.HasOne("PSF.Dominio.Entities.Usuario", null)
                        .WithMany("Matchs")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Mensagem", b =>
                {
                    b.HasOne("PSF.Dominio.Entities.Match", "Match")
                        .WithMany("Mensagens")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Animal", b =>
                {
                    b.Navigation("Curtida");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Match", b =>
                {
                    b.Navigation("Mensagens");
                });

            modelBuilder.Entity("PSF.Dominio.Entities.Usuario", b =>
                {
                    b.Navigation("Animais");

                    b.Navigation("Matchs");
                });
#pragma warning restore 612, 618
        }
    }
}