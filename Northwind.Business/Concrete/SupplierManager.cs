using Northwind.Business.Abstract;
using Northwind.Core.DataAccessLayer.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class SupplierManager : GenericManager<Supplier> , ISupplierService
    {
        public SupplierManager(IGenericRepository<Supplier> repository) : base(repository)
        {
        }
    }
}