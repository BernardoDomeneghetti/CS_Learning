using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Entities;
using System.Collections.Generic;

namespace ByteBankLib.Models.Response
{
    class AccountListResponse: BaseResponse
    {
        public List<IAccount> AccountList { get; private set; }

        public AccountListResponse(bool success, string message, ErrorCodeEnum errorCode, List<IAccount> accountList):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            if (success)
            {
                AccountList = accountList;
            }
            else
            {
                AccountList = null;
            }
        }
        public AccountListResponse(bool success, string message, List<IAccount> accountList): base(success, message)
        {
            Success = success;
            Message = message;            
            if (success)
            {
                AccountList = accountList;
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                AccountList = null;
            }

        }
        public AccountListResponse(bool success, List<IAccount> accountList)
        {
            Success = success;
            if (success)
            {
                Message = "Accounts listed successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                AccountList = accountList;
            }
            else
            {
                Message = "Accounts list failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                AccountList = null;
            }
        }
    }
}
