using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class DirectorManager:IDataRepository<Director>
{
        private readonly dbContext _dbcontext;

      public   DirectorManager(dbContext context)
        {

            _dbcontext = context;


        }

        public void Add(Director entity)
        {
            _dbcontext.Directors.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(Director entity)
        {
            _dbcontext.Directors.Remove(entity);
            _dbcontext.SaveChanges();

        }

        public Director get(int id)
        {
            return _dbcontext.Directors.FirstOrDefault(e => e.Director_id == id);

        }

        public IEnumerable<Director> getAll()
        {

            return _dbcontext.Directors.ToList<Director>();
            
        }

        public void Update(Director dbEntity, Director updatevalue)
        {

            dbEntity.Director_name = updatevalue.Director_name;
            _dbcontext.SaveChanges();
           
        }
    }
}
