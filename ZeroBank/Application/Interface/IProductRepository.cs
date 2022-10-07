using Application.Interface;
using Domain;

namespace Application.Interface
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
    }
}
