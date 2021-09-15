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

        public CustomerListResponse(bool success, string message, ErrorCodeEnum errorCode, List<Customer> CustomerList) : base(success, message, errorCode)
        {
            CustomerList = CustomerList;
        }
    }
}
