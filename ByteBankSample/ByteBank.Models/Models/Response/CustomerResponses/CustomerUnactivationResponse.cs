using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerUnactivationResponse:BaseResponse
    {
        public Customer UnactivatedCustomer { get; set; }

        public CustomerUnactivationResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer Unactivation failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            UnactivatedCustomer = null;
        }

        public CustomerUnactivationResponse(bool success, string message, ErrorCodeEnum errorCode, Customer UnactivatedCustomer) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            UnactivatedCustomer = UnactivatedCustomer;

        }
        public CustomerUnactivationResponse(bool success, string message, Customer UnactivatedCustomer) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                UnactivatedCustomer = UnactivatedCustomer;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                UnactivatedCustomer = null;
            }
            
        }
        public CustomerUnactivationResponse(bool success, Customer unactivatedCustomer)
        {
            Success = success;
            if (success)
            {
                Message = "Customer promoted successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                UnactivatedCustomer = unactivatedCustomer;
            }
            else
            {                                                                       
                Message = "Customer Unactivation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                UnactivatedCustomer = null;
            }
        }


    }
}
