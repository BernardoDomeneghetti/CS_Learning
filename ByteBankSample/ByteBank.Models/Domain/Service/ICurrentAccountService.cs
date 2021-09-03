using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Response;

namespace ByteBankLib.Domain.Service
{
    public interface ICurrentAccountService
    {
        public AccountCreationResponse RegisterNewAccount(Customer accountPrincipal, double initialValue);
        public AccountDepositResponse Deposit(int accountNumber, double value);
        public AccountWithdrawResponse Withdraw(int accountNumber, double value);
        public AccountIncreaseLimitResponse IncreaseLimit(int accountNumber, double value);
        public AccountListResponse ListRegisteredAccounts();
    }
}
