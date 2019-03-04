using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class RatingManager:IDataRepositoryFortwo<Rating>
{
        private readonly dbContext _dbcontext;

        public RatingManager(dbContext context)
        {

            _dbcontext = context;


        }
        public void Add(Rating entity)
        {
            _dbcontext.Ratings.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(Rating entity)
        {
            _dbcontext.Ratings.Remove(entity);
            _dbcontext.SaveChanges(); 

        }

        public IEnumerable<Rating> get(int user1)
        {

           return  _dbcontext.Ratings.Where(e =>  e.User_id == user1);

           
        }

        public IEnumerable<Rating> getAll()
        {

            return _dbcontext.Ratings.ToList<Rating>();

        }

        public void Update(Rating dbEntity, Rating updatevalue)
        {


            dbEntity.rating = updatevalue.rating;
         

            _dbcontext.SaveChanges();

        }


    }
}
