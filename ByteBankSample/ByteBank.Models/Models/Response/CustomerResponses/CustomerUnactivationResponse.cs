using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerUnactivationResponse:BaseResponse
    {
        public Customer RegisteredCustomer { get; set; }

        public CustomerUnactivationResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer unactivation failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            RegisteredCustomer = null;

        }

        public CustomerUnactivationResponse(bool success, string message, ErrorCodeEnum errorCode, int accountNumber) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            RegisteredCustomer = CustomerRepository.GetCustomerById(accountNumber);

        }
        public CustomerUnactivationResponse(bool success, string message, int customerId) : base(success, message)
        {
            Success = success;
            Message = message;
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
        public CustomerUnactivationResponse(bool success, int customerId)
        {
            Success = success;
            if (success)
            {
                Message = "Customer unactivated successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                RegisteredCustomer = CustomerRepository.GetCustomerById(customerId);
            }
            else
            {
                Message = "Account unactivation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                RegisteredCustomer = null;
            }
        }


    }
}
