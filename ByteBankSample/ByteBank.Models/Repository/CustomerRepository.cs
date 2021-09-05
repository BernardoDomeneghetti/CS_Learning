
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Repository
{
    public static class CustomerRepository
    {
        public static Dictionary<int, Customer>RegisteredCustomers{ get; set; }
        public static List<Customer> ListRegisteredCustomers()
        {
            return RegisteredCustomers.Select(q => q.Value).ToList<Customer>();
        }
        public static Customer GetCustomerById(int customerId)
        {
            if (RegisteredCustomers.ContainsKey(customerId))
            {
                return RegisteredCustomers[key: customerId];
            }
            else
            {
                throw new CustomerNotFoundException("The customer id was not found in the registered account's dictionary");
            }
        }
    }
}
