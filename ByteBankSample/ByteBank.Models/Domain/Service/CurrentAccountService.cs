using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Response;
using ByteBankLib.Factories;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Domain.Service
{
    public class CurrentAccountService : ICurrentAccountService
    {
        private ICurrentAccountRepository _currentAccountRepository;
        private ICurrentAccountFactory _currentAccountFactory;

        public CurrentAccountService(ICurrentAccountRepository currentAccountRepository, ICurrentAccountFactory currentAccountFactory)
        {
            _currentAccountRepository = currentAccountRepository;
            _currentAccountFactory = currentAccountFactory;
        }

        public AccountDepositResponse Deposit(int accountNumber, double value)
        {
            try
            {
                var ac = _currentAccountRepository.GetAccountByNumber(accountNumber);
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
            _currentAccountRepository.GetAccountByNumber(accountNumber).IncreaseLimit(value);
            return new AccountIncreaseLimitResponse(true);
        }

        public AccountListResponse ListRegisteredAccounts()
        {
            return new AccountListResponse(true, _currentAccountRepository.ListRegisteredAccounts());
        }

        public AccountCreationResponse RegisterNewAccount(Customer accountPrincipal, double initialValue)
        {
            return new AccountCreationResponse(true, _currentAccountFactory.GetNew(accountPrincipal, initialValue));
        }

        public AccountWithdrawResponse Withdraw(int accountNumber, double value)
        {
            _currentAccountRepository.GetAccountByNumber(accountNumber).Withdraw(value);
            return new AccountWithdrawResponse(true);
        }
    }
}
