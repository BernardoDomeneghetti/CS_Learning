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
            try
            {
                var customer = _customerRepository.GetCustomerById(customerId);
                customer.Promote();
                var response =
                        new CustomerPromotionResponse(
                            true,
                            "Customer promoted successfully!",
                            ErrorCodeEnum.NothingToDo,
                            customer
                        );
                return response;

            }
            catch (Exception e)
            {
                return new CustomerPromotionResponse(
                    false,
                    $"ERROR´: Customer promotion failed {e.Message}",
                    ErrorCodeEnum.ServerError, null
                   );
            }
        }
        public CustomerListResponse ListCustomers(int customerId)
        {
            try
            {
                var customersList = _customerRepository.ListRegisteredCustomers();
                var response = new CustomerListResponse(true, "Customer listing successeded!", ErrorCodeEnum.NothingToDo, customersList );
                return response;
            }catch(Exception e)
            {
                return new CustomerListResponse(true, "Customer listing failed!", ErrorCodeEnum.ServerError, null);
            }
            
        }
        public CustomerRegistrationResponse RegisterNewCustomer(string name, int cpf, CustomerLevelEnum customerLevel, string status)
        {
            try
            {
                var customer = _customerFactory.GetNew(name, cpf, customerLevel, status);
                var response = 
                        new CustomerRegistrationResponse(
                            true,
                            "Customer registered successfully!",
                            ErrorCodeEnum.NothingToDo,
                            customer
                        );
                return response;

            }
            catch(Exception e)
            {
                return new CustomerRegistrationResponse(
                    false, 
                    $"ERROR´: Customer Registration failed {e.Message}", 
                    ErrorCodeEnum.ServerError,null
                   );
            }
        }
        public CustomerUnactivationResponse Unactivate(int customerId)
        {
            try
            {
                var customer = _customerRepository.GetCustomerById(customerId);
                customer.Unactivate();
                var response =
                        new CustomerUnactivationResponse(
                            true,
                            "Customer unactivation successfully!",
                            ErrorCodeEnum.NothingToDo,
                            customer
                        );
                return response;

            }
            catch (Exception e)
            {
                return new CustomerUnactivationResponse(
                    false,
                    $"ERROR´: Customer unactivation failed {e.Message}",
                    ErrorCodeEnum.ServerError, null
                   );
            }
        }
    }
}
