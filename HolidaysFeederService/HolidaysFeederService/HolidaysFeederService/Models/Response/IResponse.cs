using HolidaysFeederService.Models.Enums;

namespace HolidaysFeederService.Models.Response
{
    public interface IResponse
    {
        public bool Success { get;  }
        public string Message { get; }
        public ErrorCodeEnum ErrorCode { get; }
    }
}
