using MicroServiceEduProductCatalog.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Application.Services
{
    public interface IProductService
    {
        public ProductDto Get(int productId);
        public ProductDto Create(ProductDto productDto);

    }
}
