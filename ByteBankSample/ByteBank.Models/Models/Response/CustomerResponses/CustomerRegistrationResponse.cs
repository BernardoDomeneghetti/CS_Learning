using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerRegistrationResponse:BaseResponse
    {
        public Customer RegisteredCustomer { get; set; }

        public CustomerRegistrationResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer registration failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            RegisteredCustomer = null;

        }

        public CustomerRegistrationResponse(bool success, string message, ErrorCodeEnum errorCode, int accountNumber) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            RegisteredCustomer = CustomerRepository.GetCustomerById(accountNumber);

        }
        public CustomerRegistrationResponse(bool success, string message, int customerId) : base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
            RegisteredCustomer = CustomerRepository.GetCustomerById(customerId);
        }
        public CustomerRegistrationResponse(bool success, int customerId)
        {
            Success = success;
            if (success)
            {
                Message = "Account created successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                RegisteredCustomer = CustomerRepository.GetCustomerById(customerId);
            }
            else
            {
                Message = "Account creation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                RegisteredCustomer = null;
            }
        }


    }
}
