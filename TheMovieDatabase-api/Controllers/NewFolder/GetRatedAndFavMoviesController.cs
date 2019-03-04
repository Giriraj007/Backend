using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheMovieDatabase_api.Models;

namespace TheMovieDatabase_api.Controllers.NewFolder
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetRatedAndFavMoviesController : ControllerBase
    {

        readonly private dbContext context;
        public GetRatedAndFavMoviesController(dbContext repo)
        {


            context = repo;
        }



        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {



          var ratingtab=  context.Ratings.Where(e => e.User_id == id);
            var favtab = context.Favourite_Movs.Where(e => e.User_id == id);


            var query = from rar in ratingtab
                        join fav in favtab on rar.Mov_id equals fav.Mov_id
                        select new
                        {
                            fav.Mov_id,
                            rar.rating



                        };
                        


            return Ok(query);
        }
    }
}