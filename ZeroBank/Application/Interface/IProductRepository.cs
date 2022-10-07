using Application.Interface;
using Domain;

namespace Application.Interface
{
    public interface IProductRepository
    {
        public Product CreateNewProduct(Product product);
        public List<Product> GetAllProducts();
    }
}
