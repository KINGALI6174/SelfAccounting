using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private AccountingEntities _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(AccountingEntities db)
        {
            _db = db;
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Deleted)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
    }
}
