using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("/cinemas")]
    public class CinemaController : ControllerBase
    {
        public ContextCinema _cinemaContext;

        public CinemaController(ContextCinema cinemaContext)
        {
            _cinemaContext = cinemaContext;
        }

        [HttpGet]
        public IEnumerable<Cinema> getAllCinemas()
        {
            IEnumerable<Cinema> cinema = _cinemaContext.Cinema.Include(e => e.Endereco);
            Console.WriteLine(cinema);
            return cinema;
        }

        [HttpPost]
        public IActionResult setCinema([FromBody] Cinema cinema)
        {
           
            _cinemaContext.Cinema.Add(cinema);
            _cinemaContext.SaveChanges();
            return Ok();
        }
    }
}
