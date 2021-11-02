using MicroServiceEduProductCatalog.Application.Model;
using MicroServiceEduProductCatalog.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Application.Mappers
{
    public interface IProductDtoMapper
    {
        public ProductDto Map(IProduct customer);
        public IProduct Create(ProductDto productDto);
    }
}
