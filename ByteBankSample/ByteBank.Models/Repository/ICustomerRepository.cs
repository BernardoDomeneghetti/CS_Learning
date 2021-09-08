using ByteBankLib.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLib.Repository
{
    public interface ICustomerRepository
    {        
        public Customer GetCustomerById(int customerId);
        public List<Customer> ListRegisteredCustomers();
        public void Attemp(Customer customer);
    }
}
