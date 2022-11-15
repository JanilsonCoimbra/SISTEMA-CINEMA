using FilmesApi.Model;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Sessao
    {

        [Key]
        public int IdSesao { get; set; }
        public DateTime horarioSessao { get; set; } = DateTime.Now;

        [JsonIgnore]
        public virtual Filme? filme { get; set; }
        public virtual int idFilme { get; set; }
        
        [JsonIgnore]
        public virtual Cinema? Cinema { get; set; }
        public int idCinema { get; set; }

    }
}
