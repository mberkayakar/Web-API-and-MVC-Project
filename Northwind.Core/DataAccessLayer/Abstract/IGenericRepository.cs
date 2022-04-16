using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class , new()
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Where(Expression<Func<T,bool>> filter);

    }
}
