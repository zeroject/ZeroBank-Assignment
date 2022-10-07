using Application.Interface;
using Domain;

namespace Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>() { new Product() { Id = 1, Name = "Mock", Price = 54 } };
        }
    }
}