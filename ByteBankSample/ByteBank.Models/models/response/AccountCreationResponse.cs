using ByteBank.models.enums;

namespace ByteBank.models.response
{
    class AccountCreationResponse: BaseResponse
    {
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
