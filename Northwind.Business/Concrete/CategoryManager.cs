using Northwind.Business.Abstract;
using Northwind.Core.DataAccessLayer.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public CategoryManager(IGenericRepository<Category> repository) : base(repository)
        {
        }
    }
}
