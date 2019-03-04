using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class FavouriteManager:IDataRepositoryFortwo<Favourite_Mov>
{


        private readonly dbContext _dbcontext;

        public FavouriteManager(dbContext context)
        {

            _dbcontext = context;


        }

        public void Add(Favourite_Mov entity)
        {
            _dbcontext.Favourite_Movs.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(Favourite_Mov entity)
        {
            _dbcontext.Favourite_Movs.Remove(entity);
            _dbcontext.SaveChanges();

        }

        public IEnumerable<Favourite_Mov> get(int id)
        {
            return _dbcontext.Favourite_Movs.Where(e => e.User_id == id);

        }

        public IEnumerable<Favourite_Mov> getAll()
        {

            return _dbcontext.Favourite_Movs.ToList<Favourite_Mov>();

        }

        public void Update(Favourite_Mov dbEntity, Favourite_Mov updatevalue)
        {

          
            _dbcontext.SaveChanges();

        }
    }
}
