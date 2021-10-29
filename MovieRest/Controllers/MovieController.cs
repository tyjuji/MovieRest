using Microsoft.AspNetCore.Mvc;
using MovieRest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _repo;

        public MovieController(IMovieRepository repo)
        {
            _repo = repo;
        }


        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return _repo.GetAll();
        }

        // GET api/<MovieController>/5
        [HttpGet]
        public IEnumerable<Movie> GetDay([FromBody] DateTime date)
        {
            return _repo.GetMoviesByDate(date);
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
