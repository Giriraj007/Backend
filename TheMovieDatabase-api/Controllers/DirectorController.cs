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
    public class DirectorController : ControllerBase
    {

        private readonly IDataRepository<Director> repo;

        public DirectorController(IDataRepository<Director> context)
        {

            repo = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var directors = repo.getAll();
            return Ok(directors);



        }
        [HttpGet("{id}",Name ="Get")]
        public IActionResult Get(int id)
        {
            Director director = repo.get(id);
            if (director == null)
            {

                return NotFound("The Movie record couldn't be found.");
            }
            else
            {

                return Ok(director);
            }
        }




             [HttpPost]
        public IActionResult Post([FromBody] Director director)
        {


            if (director == null)
            {

                return BadRequest("Movie is null");
            }
            repo.Add(director);
            return CreatedAtRoute("Get", new
            {
                Id = director.Director_id
            }, director);


        }


        [HttpPut("id")]
        public IActionResult Put(int id, Director director)
        {

            Director directorToUpdate = repo.get(id);
            if (director == null)
            {

                return BadRequest("Director is null");
            }
            repo.Update(directorToUpdate, director);
            return NoContent();



        }
    }
    }
