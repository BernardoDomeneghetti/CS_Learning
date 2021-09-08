using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;
using System.Collections.Generic;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerListResponse:BaseResponse
    {
        public List<Customer> CustomerList { get; set; }

        public CustomerListResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer list failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            CustomerList = null;
        }

        public CustomerListResponse(bool success, string message, ErrorCodeEnum errorCode, List<Customer> CustomerList) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            CustomerList = CustomerList;
        }
        public CustomerListResponse(bool success, string message, List<Customer> CustomerList) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                CustomerList = CustomerList;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                CustomerList = null;
            }
            
        }
        public CustomerListResponse(bool success, List<Customer> CustomerList)
        {
            Success = success;
            if (success)
            {
                Message = "Customers listed successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                CustomerList = CustomerList;
            }
            else
            {
                Message = "Customer list failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                CustomerList = null;
            }
        }


    }
}
