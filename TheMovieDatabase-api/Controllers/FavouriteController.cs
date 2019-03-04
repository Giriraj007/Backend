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
    public class FavouriteController : ControllerBase
    {

        private readonly IDataRepositoryFortwo<Favourite_Mov> repo;

        public FavouriteController(IDataRepositoryFortwo<Favourite_Mov> context)
        {

            repo = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var fav = repo.getAll();
            return Ok(fav);



        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = repo.get(id);
            if (user == null)
            {

                return NotFound("The Movie record couldn't be found.");
            }
            else
            {

                return Ok(user);
            }
        }




        [HttpPost]
        public IActionResult Post([FromBody] Favourite_Mov fav)
        {


            if (fav == null)
            {

                return BadRequest("Fav is null");
            }
            repo.Add(fav);
            return CreatedAtRoute("Get", new
            {
                Id = fav.User_id
            }, fav);


        }


        [HttpPut("id")]
        public IActionResult Put(int id, Favourite_Mov actor)
        {

           //nothing to do
            if (actor == null)
            {

                return BadRequest("actor is null");
            }
           
            return NoContent();



        }
    }
}