using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.IRepositories;


using Shop.BL.DTO;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repository
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity : class
    {
        protected readonly codeContext _context;

        public Repository(codeContext context)
        {
            this._context = context;
        }
        public IQueryable<TEntity> All()
        {
            try
            {
                var includeExpressions = this.getAllIncludes();
                var result = includeExpressions
                    .Aggregate<Expression<Func<TEntity, object>>, IQueryable<TEntity>>(_context.Set<TEntity>(), (current, expression) => current.Include(expression));
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }

     
        }
        public TEntity Update(TEntity entity)
        {
            _context.Update(entity);
            return entity;
        }
        public TEntity GetById(long id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            return entity;
        }
        protected virtual IEnumerable<Expression<Func<TEntity, object>>> getAllIncludes()
        {
            List<Expression<Func<TEntity, object>>> includeExpressions = new List<Expression<Func<TEntity, object>>>();
            return includeExpressions;
        }
        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return entity;
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
