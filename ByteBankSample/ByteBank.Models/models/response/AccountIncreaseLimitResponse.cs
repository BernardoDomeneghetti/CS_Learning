﻿using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    class AccountIncreaseLimitResponse: BaseResponse
    {
        public AccountIncreaseLimitResponse(bool success, string message, ErrorCodeEnum errorCode):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public AccountIncreaseLimitResponse(bool success, string message): base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
        }
        public AccountIncreaseLimitResponse(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "Limit increase successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                Message = "Limit increase failed";
                ErrorCode = ErrorCodeEnum.ServerError;
            }
        }
    }
}
