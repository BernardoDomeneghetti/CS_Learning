using ByteBank.models.enums;

namespace ByteBank.models.response
{
    public class BaseResponse : IBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodeEnum ErrorCode { get; set; }

        public BaseResponse(){}
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
            ErrorCode = ErrorCodeEnum.NothingToDo;
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
