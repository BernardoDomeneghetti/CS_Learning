using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    class AccountDepositResponse: BaseResponse
    {
        public AccountDepositResponse(bool success, string message, ErrorCodeEnum errorCode):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public AccountDepositResponse(bool success, string message): base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
        }
        public AccountDepositResponse(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "Deposit successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                Message = "Deposit failed";
                ErrorCode = ErrorCodeEnum.ServerError;
            }
        }
    }
}
