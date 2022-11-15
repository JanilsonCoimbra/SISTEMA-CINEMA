using FilmesApi.Data;
using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("filmes")]
public class FilmesController : ControllerBase
{
    //array de filmes
    ContextCinema _filmesContext;

    public FilmesController(ContextCinema filmesContext)
    {
        this._filmesContext = filmesContext;
    }

    [HttpGet]
    public IEnumerable<Filme> GetAllFilmes()
    {

        return _filmesContext.Filmes;
    }

    [HttpPost]
    public Object AddFilme([FromBody] Filme filme)
    {
        _filmesContext.Filmes.Add(filme);
        _filmesContext.SaveChanges();
        Console.WriteLine("Filme adicionado com sucesso! " + filme.Titulo);
        return filme;
    }

    [HttpDelete]
    public Object DeleteFilme([FromBody] Filme filme)
    {
        Filme film = _filmesContext.Filmes.Find(filme.Id);
        if (film == null)
        {
            return NoContent();
        }
        else
        {
            _filmesContext.Filmes.Remove(film);
            _filmesContext.SaveChanges();
            Console.WriteLine("Filme deletado com sucesso!");
            return film;
        }
    }

    [HttpPut]
    public Object UpdateFilme([FromBody] Filme filme)
    {
        Filme film = _filmesContext.Filmes.Find(filme.Id);
        if (film == null)
        {
            return NoContent();
        }
        else
        {
            film.Titulo = filme.Titulo;
            film.Genero = filme.Genero;
            film.Duracao = filme.Duracao;
            _filmesContext.SaveChanges();
            Console.WriteLine("Filme atualizado com sucesso!");
            return film;
        }
    }



}