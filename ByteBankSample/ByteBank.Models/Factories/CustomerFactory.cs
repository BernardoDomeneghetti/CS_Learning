using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;
using ByteBankLib.Models.Enums;


namespace ByteBankLib.Factories
{
    public class CustomerFactory: ICustomerFactory
    {
        ICustomerRepository _customerRepository;
        public CustomerFactory(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer GetNew(string name, int cpf, CustomerLevelEnum customerLevel, string status )
        {
            Random randomizer = new Random();
            Customer customer = new Customer(
                                        CustomerDataGeneratorHelper.GetCustomerId(),
                                        name,
                                        cpf,
                                        customerLevel,
                                        status
                                    );
            _customerRepository.Attemp(customer);

            return customer;
        }
    }
}
