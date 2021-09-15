using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.AccountResponses
{
    public class AccountCreationResponse: AccountResponse
    {
        public AccountCreationResponse(bool success, string message, ErrorCodeEnum errorCode, CurrentAccount account):base(success, message, errorCode, account)
        {   
        }
    }
}
