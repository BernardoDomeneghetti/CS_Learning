
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        public readonly Dictionary<int, Customer> RegisteredCustomers;

        public CustomerRepository(Dictionary<int, Customer> registeredCustomers)
        {
            RegisteredCustomers = registeredCustomers;
        }

        public List<Customer> ListRegisteredCustomers()
        {
            return RegisteredCustomers.Select(q => q.Value).ToList<Customer>();
        }
        public Customer GetCustomerById(int customerId)
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
        public void Attemp(Customer customer)
        {
            RegisteredCustomers.Add(customer.Id, customer);
        }
    }
}
