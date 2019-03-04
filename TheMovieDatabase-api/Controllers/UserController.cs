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
    public class UserController : ControllerBase
    {

        private readonly IDataRepository<User> repo;

        public UserController(IDataRepository<User> context)
        {

            repo = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var users = repo.getAll();
            return Ok(users);



        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = repo.get(id);
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
        public IActionResult Post([FromBody] User user)
        {


            if (user== null)
            {

                return BadRequest("Movie is null");
            }
            repo.Add(user);
            return CreatedAtRoute("Get", new
            {
                Id = user.User_id
            }, user);


        }


        [HttpPut("id")]
        public IActionResult Put(int id, User actor)
        {

            User userToUpdate = repo.get(id);
            if (actor == null)
            {

                return BadRequest("actor is null");
            }
            repo.Update(userToUpdate, actor);
            return NoContent();



        }
    }
}