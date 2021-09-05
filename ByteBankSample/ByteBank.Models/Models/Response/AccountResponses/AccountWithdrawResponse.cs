using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    public class AccountWithdrawResponse: BaseResponse
    {
        public AccountWithdrawResponse(bool success, string message, ErrorCodeEnum errorCode):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public AccountWithdrawResponse(bool success, string message): base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
        }
        public AccountWithdrawResponse(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "Withdraw successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                Message = "Withdraw failed";
                ErrorCode = ErrorCodeEnum.ServerError;
            }
        }
    }
}
