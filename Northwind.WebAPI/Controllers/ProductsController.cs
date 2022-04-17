using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;

namespace Northwind.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public IActionResult GetAll(string? search, int? page = 1, int size = 12, bool orderstatus = false)
        {
            var products = _productService.GetAllWithCategoryAndSupplier(page, size, search, orderstatus);
            if (products != null)
            {
                return Ok(products);
            }
            return BadRequest();
        }
    }
}