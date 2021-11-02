using MicroServiceEduProductCatalog.Domain.Model;
using MicroServiceEduProductCatalog.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Persistence.Mappers
{
    public interface IProductEfMapper
    {
        public IProduct Map(ProductEf productEf);
        public ProductEf Create(IProduct product);
    }
}
