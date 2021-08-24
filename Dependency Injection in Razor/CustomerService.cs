using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_in_Razor
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;
        public string Uid { get; set; }
        public CustomerService()
        {
            Uid = Guid.NewGuid().ToString();
            customers = new List<Customer>()
            {
                new Customer {Id = 1, Name= "Tom"},
                new Customer {Id = 2, Name= "John"},
                new Customer {Id = 3, Name= "Jill"},
            };
        }
        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
