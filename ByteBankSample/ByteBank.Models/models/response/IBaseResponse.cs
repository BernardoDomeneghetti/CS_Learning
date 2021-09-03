using ByteBank.models.enums;

namespace ByteBank.models.response
{
    public interface IBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodeEnum ErrorCode { get; set; }
    }
}
