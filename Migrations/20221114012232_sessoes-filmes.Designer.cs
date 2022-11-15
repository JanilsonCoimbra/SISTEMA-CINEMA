﻿// <auto-generated />
using System;
using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmesApi.Migrations
{
    [DbContext(typeof(ContextCinema))]
    [Migration("20221114012232_sessoes-filmes")]
    partial class sessoesfilmes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmesApi.Model.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("FilmesApi.Models.Cinema", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("FilmesApi.Models.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"));

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCinema")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("idCinema")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("FilmesApi.Models.Sessao", b =>
                {
                    b.Property<int>("IdSesao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSesao"));

                    b.Property<DateTime>("horarioSessao")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCinema")
                        .HasColumnType("int");

                    b.Property<int>("idFilme")
                        .HasColumnType("int");

                    b.HasKey("IdSesao");

                    b.HasIndex("idCinema");

                    b.HasIndex("idFilme");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("FilmesApi.Models.Endereco", b =>
                {
                    b.HasOne("FilmesApi.Models.Cinema", "Cinema")
                        .WithOne("Endereco")
                        .HasForeignKey("FilmesApi.Models.Endereco", "idCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("FilmesApi.Models.Sessao", b =>
                {
                    b.HasOne("FilmesApi.Models.Cinema", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("idCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmesApi.Model.Filme", "filme")
                        .WithMany("sessao")
                        .HasForeignKey("idFilme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("filme");
                });

            modelBuilder.Entity("FilmesApi.Model.Filme", b =>
                {
                    b.Navigation("sessao");
                });

            modelBuilder.Entity("FilmesApi.Models.Cinema", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}
