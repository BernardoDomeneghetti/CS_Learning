using ByteBankLib.Models.Response.CustomerResponses;
using ByteBankLib.Models.Enums;

namespace ByteBankLib.Domain.Service
{
    public interface ICustomerService
    {
        public CustomerRegistrationResponse RegisterNewCustomer(string name, int cpf, CustomerLevelEnum customerLevel, string status);
        public CustomerPromotionResponse Promote (int customerId);
        public CustomerUnactivationResponse Unactivate(int customerId);
    }
}
