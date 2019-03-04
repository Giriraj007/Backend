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
    public class GetMovieByGenresController : ControllerBase
    {

        readonly private dbContext repo;
        public GetMovieByGenresController(dbContext context)
        {


            repo = context;

        }


        [HttpPost("{year}")]
        public IActionResult Post([FromBody] string genres,int year)
        {


            var query = repo.Movies.Where(e => e.year == year && e.Mov_genrers == genres);
            if(query==null)
            {
                return NotFound("Movie Not Found");

            }
            return Ok(query);


            
        }
    }


}