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
    public class MovieDirectorJoinController : ControllerBase
    {
        private readonly dbContext dbContext;
        private readonly IDataRepository<Actor> _actor;
        private readonly IDataRepository<Movie> _movie;
        private readonly IDataRepository<Movie_Cast> _movie_cast;

        public MovieDirectorJoinController(IDataRepository<Movie> movie,IDataRepository<Movie_Cast> movie_cast, IDataRepository<Actor> actor)
        {
           _actor=actor ;
            _movie = movie;
            _movie_cast = movie_cast;


        }




        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            IEnumerable<Movie> movies = _movie.getAll();
            IEnumerable<Movie_Cast> movie_casts = _movie_cast.getAll();
            IEnumerable<Actor> actors = _actor.getAll();


            var query = from movie in movies
                        join movie_cast in movie_casts on movie.Mov_id equals movie_cast.Mov_id
                        join actor in actors on movie_cast.Act_id equals actor.Act_id
                        where movie.Mov_id ==id
                        select new
                        {
                            actor.Act_name,
                            actor.Act_image_url

                        };

            return Ok(query);


        }


        [HttpPost]
        public void Post()
        { }


        [HttpPut]
        public void Put()
        {


        }

        [HttpPut]
        public void Delete()
        {


        }

    }
}