using Northwind.Core.Entities.Abstract;

namespace Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }

        //public List<Product> Products { get; set; } = new List<Product>();
    }
}
