using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Assignment3_017_BayuAjiNurmansah.Models;

namespace Assignment3_017_BayuAjiNurmansah.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesContext _context;
        public MoviesController(MoviesContext context)
        {
            this._context = context;
        }

        //GET: all Movies
        public ActionResult<IEnumerable<MoviesItem>> GetMoviesItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetAllMovies();
        }

        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<MoviesItem>> GetMoviesItems(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetMovies(id);
        }

        [HttpPost]
        public string CreateMoviesItem([FromBody] MoviesItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.CreateMoviesItem(data.name, data.genre, data.duration, data.releaseDate);
        }

        [HttpPut]
        public string UpdateMoviesItem([FromBody] MoviesItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.UpdateMoviesItem(data.id, data.name, data.genre, data.duration, data.releaseDate);
        }

        [HttpDelete("{id}", Name = "Get")]
        public string DeleteMoviesItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.DeleteMoviesItem(id);
        }
    }
}
