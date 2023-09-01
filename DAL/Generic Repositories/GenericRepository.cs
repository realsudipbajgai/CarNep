using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DAL.Generic_Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void AddList(List<TEntity> entities)
        {
            foreach (var item in entities )
            {
                Add(item);
            }
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>> include=null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
            {
                query = include(query);
            }
            return query.ToList();
        }

        public TEntity GetById(
            Expression<Func<TEntity,bool>> filter=null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
           IQueryable<TEntity> query = _dbSet;
           if (filter != null)
           {
               query = query.Where(filter);
           }
            if (include != null)
            {
                query = include(query);
            }
            return query.FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
