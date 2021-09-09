
using HolidaysFeederService.Models.Enums;

namespace HolidaysFeederService.Models.Response
{
    public abstract class BaseResponse : IResponse
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public ErrorCodeEnum ErrorCode { get; protected set; }
        public BaseResponse(bool success, string message, ErrorCodeEnum errorCode) 
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
            if (success)
                ErrorCode = ErrorCodeEnum.NothingToDo;
            else
                ErrorCode = ErrorCodeEnum.ServerError;
        }
        public BaseResponse(bool success)
        {
            Success = success;
            if (success)
            {
                Message = "Operation successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
            }
            else
            {
                Message = "Operation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
            }
        }

    }
}
