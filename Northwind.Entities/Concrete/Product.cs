using Northwind.Core.Entities.Abstract;

namespace Northwind.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string Name { get; set; }

        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}