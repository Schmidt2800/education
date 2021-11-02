using MicroServiceEduCustomer.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();
            //look for any customers
            if (context.Customers.Any())
            {
                return; //db has been seeded
            }

            var customers = new CustomerEf[]
            {
                new CustomerEf{
                    FirstName = "Peter", 
                    LastName = "Larsen", 
                    Street="Jernbanegade 1",
                    PostCode="6000",
                    City="Kolding",
                    Country="Denmark",
                    Phone = "12345678",
                    Email ="rsc@unik.dk"}
            };

            foreach(CustomerEf cust in customers)
            {
                context.Customers.Add(cust);
            }
            context.SaveChanges();
        }
    }
}
