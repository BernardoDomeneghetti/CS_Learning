using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Response.AccountResponses;
using ByteBankLib.Factories;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;
using ByteBankLib.Models.Enums;
using System;

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
                var account = _currentAccountRepository.GetAccountByNumber(accountNumber);
                account.Withdraw(value);
                var response = new AccountDepositResponse(true, $"Value increased in acccount {accountNumber}'s balance successfully", ErrorCodeEnum.NothingToDo, account);
                return response;
            }
            catch (Exception e)
            {
                return new AccountDepositResponse(false, "Deposit failed", ErrorCodeEnum.ServerError, null);
            }

        }

        public AccountIncreaseLimitResponse IncreaseLimit(int accountNumber, double value)
        {
            try
            {
                var account = _currentAccountRepository.GetAccountByNumber(accountNumber);
                account.Withdraw(value);
                var response = new AccountIncreaseLimitResponse(true, $"Value increased in acccount {accountNumber}'s limit successfully", ErrorCodeEnum.NothingToDo, account);
                return response;
            }
            catch (Exception e)
            {
                return new AccountIncreaseLimitResponse(false, "Limit increasing failed", ErrorCodeEnum.ServerError, null);
            }
        }

        public AccountListResponse ListRegisteredAccounts()
        {
            try
            {
                var accountsList = _currentAccountRepository.ListRegisteredAccounts();
                var response = new AccountListResponse(true, "Account listing successeded!", ErrorCodeEnum.NothingToDo, accountsList);
                return response;
            }catch(Exception e)
            {
                return new AccountListResponse(true, "Account listing failed!", ErrorCodeEnum.ServerError, null);
            }

        }

        public AccountCreationResponse RegisterNewAccount(Customer accountPrincipal, double initialValue)
        {
            try
            {
                var account = _currentAccountFactory.GetNew(accountPrincipal, initialValue);
                var response = new AccountCreationResponse(true,"Account created successfully", ErrorCodeEnum.NothingToDo, account );
                return response;
            }catch(Exception e)
            {
                return new AccountCreationResponse(true, "Account registration failed", ErrorCodeEnum.ServerError, null);
            }
            
        }

        public AccountWithdrawResponse Withdraw(int accountNumber, double value)
        {
            try
            {
                var account = _currentAccountRepository.GetAccountByNumber(accountNumber);
                account.Withdraw(value);
                var response = new AccountWithdrawResponse(true, $"Value subtracted from acccount {accountNumber} successfully",ErrorCodeEnum.NothingToDo, account);
                return response;
            }catch(Exception e)
            {
                return new AccountWithdrawResponse(false, "Withdraw failed", ErrorCodeEnum.ServerError, null);
            }
        }
    }
}
