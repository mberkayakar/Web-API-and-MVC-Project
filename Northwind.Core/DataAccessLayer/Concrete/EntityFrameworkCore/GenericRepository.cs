using Microsoft.EntityFrameworkCore;
using Northwind.Core.DataAccessLayer.Abstract;
using Northwind.Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Northwind.Core.DataAccessLayer.Concrete.EntityFrameworkCore
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);

        }

        public IQueryable<TEntity> GetList()
        {
            return _context.Set<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }
    }
}