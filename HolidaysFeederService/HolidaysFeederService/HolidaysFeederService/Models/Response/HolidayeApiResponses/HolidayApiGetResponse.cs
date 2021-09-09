using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HolidaysFeederService.Models.Enums;

namespace HolidaysFeederService.Models.Response.HolidayeApiResponses
{
    class HolidayRepositoryDeleteResponse: BaseResponse
    {
        public HolidayRepositoryDeleteResponse(bool success, string message, ErrorCodeEnum errorCode) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
        }
        public HolidayRepositoryDeleteResponse(bool success, string message) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
                ErrorCode = ErrorCodeEnum.NothingToDo;
            else
                ErrorCode = ErrorCodeEnum.ServerError;
        }
        public HolidayRepositoryDeleteResponse(bool success) : base(success)
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
