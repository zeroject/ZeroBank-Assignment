using Domain;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        
        private IProductService _productService;
        public ProductController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _productService.GetAllProducts();
        }
    }
}