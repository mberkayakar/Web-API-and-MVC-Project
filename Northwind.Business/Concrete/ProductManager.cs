using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Northwind.Business.Abstract;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private const string CacheKey = "productsCache";
        private readonly IProductRepository _productRepository;
        private readonly IMemoryCache _memoryCache;

        public ProductManager(IProductRepository productRepository, IMemoryCache memoryCache)
        {
            _productRepository = productRepository;
            _memoryCache = memoryCache;

            //if (!memoryCache.TryGetValue(CacheKey, out _))
            //{
            //    _memoryCache.Set(CacheKey, _productRepository.GetList());
            //}
        }

        public List<Product> GetAllWithCategoryAndSupplier(int? page, int size, string? search, bool orderstatus)
        {
            //var products = _memoryCache.Get<IQueryable<Product>>(CacheKey);

            var products = _productRepository.GetList();

            if (search != null)
            {
                products = products.Where(x => x.Name.Contains(search));
            }

            if (!page.HasValue)
            {
                products = _productRepository.GetList().Take(size);
            }
            else
            {
                int pageIndex = ((int)page - 1) * size;
                products = _productRepository.GetList().Skip(pageIndex).Take(size);
            }

            if (orderstatus == true)
            {
                products = products.OrderByDescending(p => p.UnitPrice);
            }

            return products.Include(p => p.Supplier).Include(p => p.Category).ToList();
        }
    }
}