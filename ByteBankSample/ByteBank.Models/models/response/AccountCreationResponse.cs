using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    class AccountCreationResponse: BaseResponse
    {
        public AccountCreationResponse(bool success, string message, ErrorCodeEnum errorCode):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public AccountCreationResponse(bool success, string message): base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
        }
        public AccountCreationResponse(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "Account created successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                Message = "Account creation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
            }
        }
    }
}
