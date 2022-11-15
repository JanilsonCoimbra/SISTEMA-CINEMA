using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("/endereco")]
    public class EnderecoController : ControllerBase
    {
        ContextCinema _enderecoContext;

        public EnderecoController(ContextCinema enderecoContext)
        {
            _enderecoContext = enderecoContext;
        }

        [HttpGet]
        public IEnumerable<Endereco> getAllEndereco()
        {
            return _enderecoContext.Endereco;
        }

        [HttpPost]
        public Object SetEndereco([FromBody] Endereco endereco)
        {
            _enderecoContext.Endereco.Add(endereco);
            _enderecoContext.SaveChanges();
            return Ok();
        }
    }
}
