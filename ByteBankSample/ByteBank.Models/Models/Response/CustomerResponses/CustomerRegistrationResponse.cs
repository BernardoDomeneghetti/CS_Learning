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
            Message = "Customer Registration failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            RegisteredCustomer = null;
        }

        public CustomerRegistrationResponse(bool success, string message, ErrorCodeEnum errorCode, Customer RegisteredCustomer) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            RegisteredCustomer = RegisteredCustomer;

        }
        public CustomerRegistrationResponse(bool success, string message, Customer RegisteredCustomer) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                RegisteredCustomer = RegisteredCustomer;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                RegisteredCustomer = null;
            }
            
        }
        public CustomerRegistrationResponse(bool success, Customer registeredCustomer)
        {
            Success = success;
            if (success)
            {
                Message = "Customer Registered successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                RegisteredCustomer = registeredCustomer;
            }
            else
            {                                                                       
                Message = "Customer Registration failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                RegisteredCustomer = null;
            }
        }


    }
}
