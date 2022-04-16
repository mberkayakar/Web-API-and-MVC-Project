using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntityFramework.Contexts;
using Northwind.DataAccessLayer.Concrete.EntityFramework.Repositories;

namespace Northwind.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            //services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            //services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<ISupplierRepository, EfSupplierRepository>();
            //services.AddScoped<ISupplierService, SupplierManager>();
        }
    }
}