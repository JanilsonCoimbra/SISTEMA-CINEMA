using FilmesApi.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Model;

public class Filme
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public string Genero { get; set; }
    [Required]
    [Range(1, 100, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 100 minutos")]
    public int Duracao { get; set; }
    public virtual List<Sessao>? sessao { get; set; }

}