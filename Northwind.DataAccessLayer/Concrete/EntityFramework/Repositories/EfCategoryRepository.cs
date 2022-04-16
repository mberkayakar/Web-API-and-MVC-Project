using Microsoft.EntityFrameworkCore;
using Northwind.Core.DataAccessLayer.Concrete.EntityFrameworkCore;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}