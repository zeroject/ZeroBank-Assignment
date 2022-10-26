using Domain;
using Infrastructure;

namespace TestProject1
{
    public class UnitTest1
    {
        ProductRepository repository = new ProductRepository();
        
        [Fact]
        public void Test1()
        {
            List<Product> products = new List<Product>() { new Product() { Id = 1, Name = "Mock", Price = 54 } };

            Assert.Equal(1, products.Count);
        }
        [Fact]
        public void Test2()
        {
            List<Product> products = new List<Product>() { new Product() { Id = 1, Name = "Mock", Price = 54 } };

            Assert.Equal(repository.GetAllProducts(), products);
        }
    }
}