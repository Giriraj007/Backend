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
    public class CalculateAvgController : ControllerBase
    {
        readonly private dbContext dbcontext;

        IDataRepositoryFortwo<Rating> rating;
        public CalculateAvgController(IDataRepositoryFortwo<Rating> context, dbContext contexts)
        {
            rating = context;
            dbcontext = contexts;


        }



        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var Ratings = rating.getAll();


            var query = dbcontext.Ratings.Where(e => e.Mov_id==id);
            if(query.Count()==0)
            {
                return NoContent();
            }
            var count = query.Average(e => e.rating);

            return Ok(count);



        }
    }
}