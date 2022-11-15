using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        [Required]
        public string rua { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        [JsonIgnore]
        public virtual Cinema? Cinema { get; set; }
        public int idCinema { get; set; }
    }
}
