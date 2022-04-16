namespace Northwind.Entities.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description  { get; set; }
        public string Pictures { get; set; }

        public List<Product> Products { get; set; }
    }
}
