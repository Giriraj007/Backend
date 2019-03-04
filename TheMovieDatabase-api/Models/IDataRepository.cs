using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
  public   interface IDataRepository<TEntity>
{
        IEnumerable<TEntity> getAll();
        TEntity get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity updatevalue);
        void Delete(TEntity entity);

}


    public interface IDataRepositoryFortwo<TEntity>
    {
        IEnumerable<TEntity> getAll();
        IEnumerable<TEntity> get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity updatevalue);
        void Delete(TEntity entity);



    }
}