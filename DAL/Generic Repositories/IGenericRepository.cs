using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Generic_Repositories
{
    internal interface IGenericRepository<TEntity,Tkey> where TEntity:class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Edit(params TEntity[] entities);
        void Delete(TEntity entity);
        void DeleteList(List<TEntity> entities);
        void AddList(List<TEntity> entities);
        TEntity GetById(int id);
        List<TEntity> GetAll();

    }
}
