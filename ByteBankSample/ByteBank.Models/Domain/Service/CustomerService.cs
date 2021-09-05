using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Response.CustomerResponses;
using System;
using ByteBankLib.Repository;

namespace ByteBankLib.Domain.Service
{
    class CustomerService : ICustomerService
    {
        public CustomerPromotionResponse Promote(int customerId)
        {
            return new CustomerPromotionResponse(true,)
        }

        public CustomerRegistrationResponse RegisterNewCustomer(string name, int cpf, CustomerLevelEnum customerLevel, string status)
        {
            throw new NotImplementedException();
        }

        public CustomerUnactivationResponse Unactivate(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
