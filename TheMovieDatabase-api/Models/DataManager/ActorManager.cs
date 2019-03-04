using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class ActorManager:IDataRepository<Actor>
{
        private readonly dbContext _dbcontext;

        public ActorManager(dbContext context)
        {

            _dbcontext = context;


        }
        public void Add(Actor entity)
        {
            _dbcontext.Actorss.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(Actor entity)
        {
            _dbcontext.Actorss.Remove(entity);
            _dbcontext.SaveChanges();

        }

        public Actor get(int id)
        {
            return _dbcontext.Actorss.FirstOrDefault(e => e.Act_id == id);

        }

        public IEnumerable<Actor> getAll()
        {

            return _dbcontext.Actorss.ToList<Actor>();

        }

        public void Update(Actor dbEntity, Actor updatevalue)
        {

            dbEntity.Act_name = updatevalue.Act_name;
            dbEntity.Act_image_url = updatevalue.Act_image_url;

            _dbcontext.SaveChanges();

        }




    }
}
