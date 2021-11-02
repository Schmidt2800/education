using MicroServiceEduProductCatalog.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduProductCatalog.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();
            //look for any products
            if (context.Products.Any())
            {
                return; //db has been seeded
            }

            var products = new ProductEf[]
            {
                new ProductEf{
                 Name = "Cykel",
                 Price = 999.95M,
                 EAN = "0898878987"
                }
            };

            foreach (ProductEf product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
