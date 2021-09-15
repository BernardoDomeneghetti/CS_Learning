using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response.AccountResponses
{
    public class AccountResponse: BaseResponse
    {
        public Account Account { get; private set; }

        public AccountResponse(bool success, string message, ErrorCodeEnum errorCode, Account account) : base(success, message, errorCode)
        {
            Account = account;
        }
    }
}
