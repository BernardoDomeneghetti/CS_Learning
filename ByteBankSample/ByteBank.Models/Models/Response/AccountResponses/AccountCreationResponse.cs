using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response
{
    public class AccountCreationResponse: BaseResponse
    {
        public CurrentAccount CurrentAccount { get; set; }
        public AccountCreationResponse(bool success, string message, ErrorCodeEnum errorCode, int accountNumber):base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            CurrentAccount = CurrentAccountRepository.GetAccountByNumber(accountNumber);
            
        }
        public AccountCreationResponse(bool success, string message, int accountNumber): base(success, message)
        {
            Success = success;
            Message = message;
            ErrorCode = ErrorCodeEnum.NothingToDo;
            CurrentAccount = CurrentAccountRepository.GetAccountByNumber(accountNumber);
        }
        public AccountCreationResponse(bool success, int accountNumber)
        {
            Success = success;
            if (success)
            {
                Message = "Account created successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                CurrentAccount = CurrentAccountRepository.GetAccountByNumber(accountNumber);
            }
            else
            {
                Message = "Account creation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                CurrentAccount = null;
            }
        }

        public AccountCreationResponse(bool success)
        {
            Success = success;
            if (success)
            {
                throw new AccountResponseMisusedConstructorException("This constructor should be used only for for failed operations");
            }
            else
            {
                Message = "Account creation failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                CurrentAccount = null;
            }
        }
    }
}
