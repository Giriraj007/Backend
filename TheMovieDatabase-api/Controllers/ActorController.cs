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
    public class ActorController : ControllerBase
    {
        private readonly IDataRepository<Actor> repo;

        public ActorController(IDataRepository<Actor> context)
        {

            repo = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var actors = repo.getAll();
            return Ok(actors);



        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Actor actor = repo.get(id);
            if (actor == null)
            {

                return NotFound("The Movie record couldn't be found.");
            }
            else
            {

                return Ok(actor);
            }
        }




        [HttpPost]
        public IActionResult Post([FromBody] Actor actor)
        {


            if (actor == null)
            {

                return BadRequest("Movie is null");
            }
            repo.Add(actor);
            return CreatedAtRoute("Get", new
            {
                Id = actor.Act_id
            }, actor);


        }


        [HttpPut("id")]
        public IActionResult Put(int id, Actor actor)
        {

            Actor actorToUpdate = repo.get(id);
            if (actor == null)
            {

                return BadRequest("actor is null");
            }
            repo.Update(actorToUpdate, actor);
            return NoContent();



        }


    }
}