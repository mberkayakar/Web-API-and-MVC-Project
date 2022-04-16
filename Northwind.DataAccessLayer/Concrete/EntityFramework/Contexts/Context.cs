using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public class Context: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security=true ");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


    }
}
