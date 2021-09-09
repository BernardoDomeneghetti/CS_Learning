using HolidaysFeederService.Models.Response;
using HolidaysFeederService.Models.Enums;
using HolidaysFeederService.Models.Entities;

namespace HolidaysFeederService.Response.HolidayRepositoryReponse
{
    public class HolidayAppendResponse: BaseResponse
    {
        public Holiday Holiday{ get; set; }
        public HolidayAppendResponse(bool success, string message, ErrorCodeEnum errorCode, Holiday holiday) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            Holiday = holiday;
        }
        public HolidayAppendResponse(bool success, string message, Holiday holiday) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                Holiday = holiday;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                Holiday = null;
            }
        }
        public HolidayAppendResponse(bool success ) : base(success)
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