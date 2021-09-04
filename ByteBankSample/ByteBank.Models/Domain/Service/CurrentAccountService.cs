using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Response;
using ByteBankLib.Factories;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Domain.Service
{
    public class CurrentAccountService : ICurrentAccountService
    {
        public AccountDepositResponse Deposit(int accountNumber, double value)
        {
            try
            {
                var ac = CurrentAccountRepository.GetAccountByNumber(accountNumber);
                ac.Deposit(value);

                return new AccountDepositResponse(true, ac.Balance);
            }
            catch (AccoutnNotFoundException)
            {
                return new AccountDepositResponse(false);
            }
            
        }

        public AccountIncreaseLimitResponse IncreaseLimit(int accountNumber, double value)
        {
            CurrentAccountRepository.GetAccountByNumber(accountNumber).IncreaseLimit(value);
            return new AccountIncreaseLimitResponse(true);
        }

        public AccountListResponse ListRegisteredAccounts()
        {
            return new AccountListResponse(true, CurrentAccountRepository.ListRegisteredAccounts());
        }

        public AccountCreationResponse RegisterNewAccount(Customer accountPrincipal, double initialValue)
        {
            return new AccountCreationResponse(true, CurrentAccountFactory.GetNumberedCurrentAccount(accountPrincipal, initialValue).AccountNumber);
        }

        public AccountWithdrawResponse Withdraw(int accountNumber, double value)
        {
            CurrentAccountRepository.GetAccountByNumber(accountNumber).Withdraw(value);
            return new AccountWithdrawResponse(true);
        }
    }
}
