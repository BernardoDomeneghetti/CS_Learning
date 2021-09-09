using HolidaysFeederService.Models.Response;
using HolidaysFeederService.Models.Enums;
using HolidaysFeederService.Models.Entities;
using System.Collections.Generic;

namespace HolidaysFeederService.Response.HolidayRepositoryReponse
{
    public class HolidayListResponse: BaseResponse
    {
        public List<Holiday> HolidayList{ get; set; }
        public HolidayListResponse(bool success, string message, ErrorCodeEnum errorCode, List<Holiday> holidayList): base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            HolidayList = holidayList;
        }
        public HolidayListResponse(bool success, string message, List<Holiday> holidayList) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                HolidayList = holidayList;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                HolidayList = null;
            }
                
                
        }
        public HolidayListResponse(bool success, List<Holiday> holidayList) :base(success)
        {
            Success = success;
            if (success)
            {
                Message = "Operation successeded";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                HolidayList = holidayList;
            }
            else
            {
                Message = "Operation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                HolidayList = null;
            }
        }
        
    }
}