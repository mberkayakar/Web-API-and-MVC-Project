﻿using Northwind.Core.DataAccessLayer.Concrete.EntityFrameworkCore;
using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntityFramework.Contexts;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class SupplierRepository : GenericRepository<Supplier,Context>, ISupplierRepository
    {

    }
}
