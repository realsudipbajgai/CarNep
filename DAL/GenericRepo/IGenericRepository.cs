using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace DAL.GenericRepo
{
    public interface IGenericRepository<TEntity,Tkey> where TEntity:class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);
        IEnumerable<TEntity> GetAll(
            Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>> include=null
            );

    }
}
