using MicroServiceEduProductCatalog.Application.Mappers;
using MicroServiceEduProductCatalog.Application.Model;
using MicroServiceEduProductCatalog.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IProductDtoMapper _ProductDtoMapper;
        public ProductService(IProductRepository productRepository, IProductDtoMapper productDtoMapper)
        {
            _ProductRepository = productRepository;
            _ProductDtoMapper = productDtoMapper;
        }
        public ProductDto Create(ProductDto productDto)
        {
            var product = _ProductDtoMapper.Create(productDto);
            var createdProduct = _ProductRepository.CreateProduct(product);

            return _ProductDtoMapper.Map(createdProduct);
        }

        public ProductDto Get(int productId)
        {
            var product = _ProductRepository.GetProduct(productId);
            return _ProductDtoMapper.Map(product);
        }
    }
}
