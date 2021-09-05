using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;
using ByteBankLib.Models.Enums;


namespace ByteBankLib.Factories
{
    public class CustomerFactory
    {
        public static Customer Get(string name, int cpf, CustomerLevelEnum customerLevel, string status )
        {
            Random _randomizer = new Random();
            Customer _customer = new Customer(
                                        CustomerDataGeneratorHelper.GetCustomerId(),
                                        name,
                                        cpf,
                                        customerLevel,
                                        status
                                    );
            CustomerRepository.RegisteredCustomers.Add(_customer.Id, _customer);

            return _customer;
        }
    }
}
