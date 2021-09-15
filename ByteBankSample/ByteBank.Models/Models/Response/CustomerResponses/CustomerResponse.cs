using ByteBankLib.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankLib.Models.Entities;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerResponse : BaseResponse
    {
        public Customer Customer { get; private set; }
        public CustomerResponse(bool success, string message, ErrorCodeEnum errorCode, Customer customer) : base(success, message, errorCode)
        {
            Customer = customer;
        }
    }
}
