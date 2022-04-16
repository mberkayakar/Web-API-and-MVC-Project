using System.Linq.Expressions;

namespace Northwind.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
        IEnumerable<T> Where(Expression<Func<T, bool>> filter);
    }
}
