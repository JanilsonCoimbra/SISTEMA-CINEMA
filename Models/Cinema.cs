using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public virtual Endereco? Endereco { get; set; }

        public virtual List<Sessao>? Sessoes { get; set; }

    }
}
