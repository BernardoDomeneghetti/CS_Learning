using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Models.Response
{
    public class AccountDepositResponse: BaseResponse
    {
        public double ActualBalance{ get; set; }
        public AccountDepositResponse(bool success, string message, ErrorCodeEnum errorCode, double actualBalance):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            ActualBalance = actualBalance;
        }
        public AccountDepositResponse(bool success, string message, double actualBalance) : base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
            ActualBalance = actualBalance;
        }
        public AccountDepositResponse(bool success, double actualBalance)
        {
            Success = success;
            if (success)
            {
                Message = "Deposit successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                ActualBalance = actualBalance;
            }
            else
            {
                Message = "Deposit failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                ActualBalance = 0;
            }
        }

        public AccountDepositResponse(bool success)
        {
            Success = success;
            if (success)
            {
                throw new AccountResponseMisusedConstructorException("This constructor should be used only for for failed operations");
            }
            else
            {
                Message = "Deposit failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                ActualBalance = 0;
            }
        }
    }
}

