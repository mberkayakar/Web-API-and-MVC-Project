using Northwind.Core.DataAccessLayer.Concrete.EntityFrameworkCore;
using Northwind.DataAccessLayer.Concrete.EntityFramework.Contexts;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class CategoryRepository : GenericRepository<Category,Context> : 
    {
    }
}
