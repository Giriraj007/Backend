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
    public class GetByNameController : ControllerBase
    {


        private readonly IDataRepository<Movie> repo;
        public GetByNameController(IDataRepository<Movie> context)
        {

            repo = context;

        }


        [HttpGet("{name}")]
        public IActionResult Get( string name)
        {
            var Name = name.Trim();
            var movies = repo.getAll();

            var query = from movie in movies
                        where movie.Mov_name == Name
                        select movie;
            if(query==null)
            {
                return NotFound("Movie not found");

            }

            return Ok(query);

        }
    }
}