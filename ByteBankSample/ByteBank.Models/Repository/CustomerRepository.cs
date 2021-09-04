
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
        public static CurrentAccount GetAccountByNumber(int accountNumber)
        {
            if (RegisteredCustomers.ContainsKey(accountNumber))
            {
                return RegisteredCurrentAccounts[key: accountNumber];
            }
            else
            {
                throw new AccoutnNotFoundException("The number account was not found in the registered account's dictionary");
            }
        }
    }
}
