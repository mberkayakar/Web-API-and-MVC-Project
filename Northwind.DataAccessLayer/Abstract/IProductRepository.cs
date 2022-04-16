using Northwind.Core.DataAccessLayer.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccessLayer.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
