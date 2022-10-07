using Application.DTOs;
using Application.Interface;
using AutoMapper;
using Domain;
using Domain.Interface;
using FluentValidation;
using System.Runtime.CompilerServices;

namespace Application
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        private IMapper _mapper;
        private IValidator<PostProductDTO> _postValidator;
        public ProductService(IProductRepository repository, IMapper mapper, IValidator<PostProductDTO> postValidator)
        {
            _mapper = mapper;
            _repository = repository;
            _postValidator = postValidator;
        }

        public Product CreateNewProduct(PostProductDTO dto)
        {
            var validation = _postValidator.Validate(dto);
            if (!validation.IsValid)
                throw new ValidationException(validation.ToString());

            return _repository.CreateNewProduct(_mapper.Map<Product>(dto));
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

    }
}