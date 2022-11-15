using FilmesApi.Model;
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class ContextCinema : DbContext
    {
        public ContextCinema(DbContextOptions<ContextCinema> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Endereco>(endereco => endereco.idCinema);

            builder.Entity<Cinema>()
                .HasMany(cinema => cinema.Sessoes)
                .WithOne(sessoes => sessoes.Cinema)
                .HasForeignKey(sessao => sessao.idCinema);

            builder.Entity<Sessao>()
                .HasOne(filme => filme.filme)
                .WithMany(filmes => filmes.sessao)
                .HasForeignKey(sessao => sessao.idFilme);

        }

        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
    }
}