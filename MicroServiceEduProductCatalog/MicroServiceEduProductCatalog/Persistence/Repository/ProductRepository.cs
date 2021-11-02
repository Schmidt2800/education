using MicroServiceEduProductCatalog.Domain.Model;
using MicroServiceEduProductCatalog.Domain.Repository;
using MicroServiceEduProductCatalog.Persistence.Mappers;
using MicroServiceEduProductCatalog.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _Context;
        private readonly IProductEfMapper __Mapper;
        public ProductRepository(ProductContext context, IProductEfMapper mapper)
        {
            _Context = context;
            __Mapper = mapper;
        }
        public IProduct CreateProduct(IProduct product)
        {
            var productEf = __Mapper.Create(product);
            _Context.Add(productEf);
            _Context.SaveChanges();
            return __Mapper.Map(productEf);
        }

        public IProduct GetProduct(int productId)
        {
            var productEf = GetProductEf(productId);
            return __Mapper.Map(productEf);
        }
        private ProductEf GetProductEf(int productId)
        {
            return _Context.Products.FirstOrDefault(c => c.ID == productId);
        }
    }
}
