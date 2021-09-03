using ByteBankLib.Models.Enums;

namespace ByteBankLib.Models.Response
{
    public interface IBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodeEnum ErrorCode { get; set; }
    }
}
