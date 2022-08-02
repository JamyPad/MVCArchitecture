using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.IRepositories
{
    public interface IRepository<TEntity>
    {
        TEntity Add(TEntity entity);
        IQueryable<TEntity> All();
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(long id);
        int SaveChanges();
    }
}
