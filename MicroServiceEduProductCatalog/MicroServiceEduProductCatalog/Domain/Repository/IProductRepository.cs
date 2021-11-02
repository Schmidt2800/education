using MicroServiceEduProductCatalog.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Domain.Repository
{
    public interface IProductRepository
    {
        public IProduct GetProduct(int productId);
        public IProduct CreateProduct(IProduct product);
    }
}
