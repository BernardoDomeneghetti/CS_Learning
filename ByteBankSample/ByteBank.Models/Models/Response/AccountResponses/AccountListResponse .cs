using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Entities;
using System.Collections.Generic;

namespace ByteBankLib.Models.Response.AccountResponses
{
    public class AccountListResponse: BaseResponse
    {
        public List<IAccount> AccountList { get; private set; }

        public AccountListResponse(bool success, string message, ErrorCodeEnum errorCode, List<IAccount> accountList):base(success, message, errorCode)
        {
            AccountList = accountList;
        }
    }
}
