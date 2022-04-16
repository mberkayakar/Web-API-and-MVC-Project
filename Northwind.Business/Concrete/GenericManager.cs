using Northwind.Business.Abstract;
using Northwind.Core.DataAccessLayer.Abstract;
using Northwind.Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Northwind.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, IEntity, new()
    {

        private IGenericRepository<T> _repository;

        public GenericManager(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> filter)
        {
            return _repository.Where(filter);
        }
    }
}
