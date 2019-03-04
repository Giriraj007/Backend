using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class MovieCastManger:IDataRepository<Movie_Cast>
{
        private readonly dbContext _dbcontext;
        public MovieCastManger(dbContext repo)
        {

            _dbcontext = repo;
        }

        public void Add(Movie_Cast entity)
        {
           
        }

        public void Delete(Movie_Cast entity)
        {
           
        }

        public Movie_Cast get(int id)
        {
            return null;
        }

        public IEnumerable<Movie_Cast> getAll()
        {
            return _dbcontext.Movie_Casts.ToList<Movie_Cast>();
        }

        public void Update(Movie_Cast dbEntity, Movie_Cast updatevalue)
        {
            throw new NotImplementedException();
        }
    }
}
