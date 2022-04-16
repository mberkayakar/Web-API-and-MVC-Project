using Microsoft.EntityFrameworkCore;
using Northwind.DataAccessLayer.Concrete.EntityFramework.Mappings;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new SupplierMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


    }
}
