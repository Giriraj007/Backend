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
    public class RatingController : ControllerBase
    {
        private readonly IDataRepositoryFortwo<Rating> repo;

        public RatingController(IDataRepositoryFortwo<Rating> context)
        {

            repo = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var ratings = repo.getAll();
            return Ok(ratings);



        }
       [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var rating = repo.get(id);
            if (rating == null)
            {
               
                return NotFound("The Movie record couldn't be found.");
            }
            else
            {

                return Ok(rating);
            }
        }




        [HttpPost]
        public IActionResult Post([FromBody] Rating rating)
        {


            if (rating == null)
            {

                return BadRequest("Rating is null");
            }
            repo.Add(rating);
            return CreatedAtRoute("Get", new
            {
                Id = rating.User_id
            }, rating);


        }


        [HttpPut("{id}")]
        public IActionResult Put([FromRoute]int id,[FromRoute]int Mov_id, Rating rating)
        {

            IEnumerable<Rating> ratingToUpdate = repo.get(Mov_id);
            if (rating == null)
            {

                return BadRequest("actor is null");
            }
           
            return NoContent();



        }
    }

    public class iobj
    {
      public int User_id { get; set; }
     public int Mov_id { get; set; }
    }
}