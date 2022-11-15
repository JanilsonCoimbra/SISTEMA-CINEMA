using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("/sessao")]
    public class SessaoController : ControllerBase
    {
        ContextCinema _filmeContext;
        public SessaoController(ContextCinema filmeContext)
        {
            _filmeContext = filmeContext;
        }

        [HttpGet]
        public IEnumerable<Sessao> GetAllSessoes()
        {
            return _filmeContext.Sessao;
        }

        [HttpPost]
        public IActionResult SetSessao([FromBody] Sessao sessao)
        {
            try
            {
                _filmeContext.Sessao.Add(sessao);
                _filmeContext.SaveChanges();
                return Ok(sessao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}
