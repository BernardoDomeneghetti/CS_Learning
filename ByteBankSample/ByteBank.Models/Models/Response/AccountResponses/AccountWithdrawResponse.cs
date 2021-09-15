using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Entities;

namespace ByteBankLib.Models.Response.AccountResponses
{
    public class AccountWithdrawResponse: AccountResponse
    {
        public AccountWithdrawResponse(bool success, string message, ErrorCodeEnum errorCode, Account account):base(success, message, errorCode, account)
        {
        }
        
    }
}
