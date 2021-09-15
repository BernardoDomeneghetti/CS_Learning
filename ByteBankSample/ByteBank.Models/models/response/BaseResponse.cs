using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    public class BaseResponse : IBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodeEnum ErrorCode { get; set; }

        
        public BaseResponse(bool success, string message, ErrorCodeEnum errorCode) 
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
    }
}
