using Application.DTOs;
using Domain;
using Domain.Interface;
using FluentValidation;
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

        [HttpPost]
        public ActionResult<Product> CreateNewProduct(PostProductDTO dto)
        {
            try
            {
                var result = _productService.CreateNewProduct(dto);
                return Created("product/"+result.Id, result);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            } 
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}