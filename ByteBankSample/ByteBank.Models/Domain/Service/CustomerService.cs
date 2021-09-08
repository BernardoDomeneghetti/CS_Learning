using ByteBankLib.Factories;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Response.CustomerResponses;
using System;
using ByteBankLib.Repository;

namespace ByteBankLib.Domain.Service
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;
        ICustomerFactory _customerFactory;

        public CustomerService(ICustomerRepository customerRepository, ICustomerFactory customerFactory)
        {
            _customerRepository = customerRepository;
            _customerFactory = customerFactory;
        }

        public CustomerPromotionResponse Promote(int customerId)
        {
            var cus = _customerRepository.GetCustomerById(customerId);
            cus.Promote();

            return new CustomerPromotionResponse(true, cus);
        }
        public CustomerListResponse ListCustomers(int customerId)
        {
            return new CustomerListResponse(true, _customerRepository.ListRegisteredCustomers());
        }
        public CustomerRegistrationResponse RegisterNewCustomer(string name, int cpf, CustomerLevelEnum customerLevel, string status)
        {            
            return new CustomerRegistrationResponse(
                true, 
                _customerFactory.GetNew(name, cpf, customerLevel, status)
            );
        }
        public CustomerUnactivationResponse Unactivate(int customerId)
        {
            var cus = _customerRepository.GetCustomerById(customerId);
            cus.Unactivate();

            return new CustomerUnactivationResponse(true, cus);
        }
    }
}
