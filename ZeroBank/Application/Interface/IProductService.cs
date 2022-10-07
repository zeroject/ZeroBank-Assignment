using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IProductService
    {
        public Product CreateNewProduct(PostProductDTO dto);
        public List<Product> GetAllProducts();
    }
}
