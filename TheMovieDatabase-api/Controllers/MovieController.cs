using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheMovieDatabase_api.Models;

namespace TheMovieDatabase_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IDataRepository<Movie> _dataRepo;
      public   MovieController(IDataRepository<Movie> data)
        {

            _dataRepo = data;
        }

        //GET: api/Movie
        [HttpGet]
        public IActionResult Get()
        {


            var movies = _dataRepo.getAll();
            return Ok(movies); }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Movie movie = _dataRepo.get(id);
            if (movie == null)
            {

                return NotFound("The Movie record couldn't be found.");
            }
            else
            {

                return Ok(movie);
            }

        }


        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {


            if (movie == null)
            {

                return BadRequest("Movie is null");
            }
            _dataRepo.Add(movie);
            return CreatedAtRoute("Get", new
            {
                Id = movie.Mov_id
            }, movie);


        }
        


        [HttpPut("id")]
        public IActionResult Put(int id,Movie movie)
        {

            Movie movieToUpdate = _dataRepo.get(id);
            if(movie==null)
            {

                return BadRequest("Movie is null");
            }
            _dataRepo.Update(movieToUpdate, movie);
            return NoContent();



        }


    }
}

   
