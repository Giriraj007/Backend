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
    public class GetTheaterController : ControllerBase
    {

        readonly private dbContext repo;
        public GetTheaterController(dbContext context)
        {

            repo = context;
        }


        [HttpGet]
        public IActionResult Get()
        {

            var list = repo.Movies.Where(e => e.isintheator == true);
            if(list==null)
            {

                return NotFound("No movies in theater");

            }
            return Ok(list);


        }
    }
}