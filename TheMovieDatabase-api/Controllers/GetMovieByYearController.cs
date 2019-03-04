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
    public class GetMovieByYearController : ControllerBase
    {


        readonly private dbContext repo;
       public  GetMovieByYearController(dbContext context)
        {
            repo = context;


        }


        [HttpGet("{year}")]
        public IActionResult Get(int year)
        {

            var query = repo.Movies.Where(e => e.year == year);
            if(query==null)
            {

                return NotFound("No content for the year");
            }
            return Ok(query);


        }
    }
}