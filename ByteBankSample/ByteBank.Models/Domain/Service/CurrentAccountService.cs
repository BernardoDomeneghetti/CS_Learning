using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Response;
using ByteBankLib.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLib.Domain.Service
{
    class CurrentAccountService : ICurrentAccountService
    {
        public AccountDepositResponse Deposit(int accountNumber, double value)
        {
            CurrentAccount.GetAccountByNumber(accountNumber).Deposit(value);
            return new AccountDepositResponse(true);
        }

        public AccountIncreaseLimitResponse IncreaseLimit(int accountNumber, double value)
        {
            CurrentAccount.GetAccountByNumber(accountNumber).IncreaseLimit(value);
            return new AccountIncreaseLimitResponse(true);
        }

        public AccountListResponse ListRegisteredAccounts()
        {
            return new AccountListResponse(true,Account.ListRegisteredAccounts());
        }

        public AccountCreationResponse RegisterNewAccount(Customer accountPrincipal, double initialValue)
        {
            CurrentAccountFactory.GetNumberedCurrentAccount(accountPrincipal, initialValue);
            return new AccountCreationResponse(true);
        }

        public AccountWithdrawResponse Withdraw(int accountNumber, double value)
        {
            CurrentAccount.GetAccountByNumber(accountNumber).Withdraw(value);
            return new AccountWithdrawResponse(true);
        }
    }
}
