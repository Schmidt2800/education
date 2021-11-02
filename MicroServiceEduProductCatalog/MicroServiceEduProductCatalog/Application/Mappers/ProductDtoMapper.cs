﻿using MicroServiceEduProductCatalog.Application.Model;
using MicroServiceEduProductCatalog.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Application.Mappers
{
    public class ProductDtoMapper : IProductDtoMapper
    {
        public IProduct Create(ProductDto productDto)
        {
            return new ProductEf
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                EAN = product.EAN
            };
        }

        public ProductDto Map(IProduct product)
        {
            return new ProductDto
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                EAN = product.EAN
            };
        }
    }
}
