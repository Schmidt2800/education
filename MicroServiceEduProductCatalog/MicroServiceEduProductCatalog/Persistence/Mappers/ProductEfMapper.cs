using MicroServiceEduProductCatalog.Domain.Model;
using MicroServiceEduProductCatalog.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Persistence.Mappers
{
    public class ProductEfMapper : IProductEfMapper
    {
        public ProductEf Create(IProduct product)
        {

            return new ProductEf
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                EAN = product.EAN
            };
         
        }

        public IProduct Map(ProductEf productEf)
        {
            return new Product
            {
                ID = productEf.ID,
                Name = productEf.Name,
                Price = productEf.Price,
                EAN = productEf.EAN
            };
        }
    }
}
