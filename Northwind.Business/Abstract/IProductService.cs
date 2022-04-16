using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllWithCategoryAndSupplier(int? page, int size, string search, bool orderstatus);
    }
}