using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models.DataManager
{
    public class UserManager:IDataRepository<User>
{


        private readonly dbContext _dbcontext;

        public UserManager(dbContext context)
        {

            _dbcontext = context;


        }
        public void Add(User entity)
        {
            _dbcontext.Users.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(User entity)
        {
            _dbcontext.Users.Remove(entity);
            _dbcontext.SaveChanges();

        }

        public User get(int id)
        {
            return _dbcontext.Users.FirstOrDefault(e => e.User_id == id);

        }

        public IEnumerable<User> getAll()
        {

            return _dbcontext.Users.ToList<User>();

        }

        public void Update(User dbEntity, User updatevalue)
        {

            dbEntity.User_name = updatevalue.User_name;
            dbEntity.Email_id = updatevalue.Email_id;
            dbEntity.password = updatevalue.password;

            _dbcontext.SaveChanges();

        }

    }
}
