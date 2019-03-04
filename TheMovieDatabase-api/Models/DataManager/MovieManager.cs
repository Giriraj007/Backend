using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class MovieManager : IDataRepository<Movie> { 
      readonly dbContext dbcontext;


        public MovieManager(dbContext context)
    {
            dbcontext = context;
        
    }


        public IEnumerable<Movie> getAll()
        {

            return dbcontext.Movies.ToList();
        }

        public void  Add(Movie movie)
        {
            dbcontext.Movies.Add(movie);
            dbcontext.SaveChanges();

        }

        public void Delete(Movie movie)
        {

            dbcontext.Movies.Remove(movie);
            dbcontext.SaveChanges();

        }

        public Movie get(int id)
        {
            return dbcontext.Movies.FirstOrDefault(e => e.Mov_id == id);
        }

       

        public void Update(Movie dbEntity, Movie updatevalue)
        {
            dbEntity.Mov_name = updatevalue.Mov_name;
            dbEntity.Mov_description = updatevalue.Mov_description;
            dbEntity.Mov_image_url = updatevalue.Mov_image_url;
            dbEntity.Avg_rating = calculateRating();
            dbEntity.Director_id = updatevalue.Director_id;
            dbEntity.year = updatevalue.year;
            dbEntity.Mov_genrers = updatevalue.Mov_genrers;
            dbcontext.SaveChanges();


                    }

        public float calculateRating()
        {

            return 7.5f;
        }


      
    }
}
