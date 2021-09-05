using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerPromotionResponse:BaseResponse
    {
        public Customer RegisteredCustomer { get; set; }

        public CustomerPromotionResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer promotion failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            RegisteredCustomer = null;

        }

        public CustomerPromotionResponse(bool success, string message, ErrorCodeEnum errorCode, ) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            RegisteredCustomer = CustomerRepository.GetCustomerById(accountNumber);

        }
        public CustomerPromotionResponse(bool success, string message, int customerId) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
            }
            RegisteredCustomer = CustomerRepository.GetCustomerById(customerId);
        }
        public CustomerPromotionResponse(bool success, int customerId)
        {
            Success = success;
            if (success)
            {
                Message = "Customer promoted successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                RegisteredCustomer = CustomerRepository.GetCustomerById(customerId);
            }
            else
            {
                Message = "Customer promotion failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                RegisteredCustomer = null;
            }
        }


    }
}
