
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Repository
{
    public class CurrentAccountRepository: ICurrentAccountRepository
    {        

        private readonly Dictionary<int, CurrentAccount> _registeredCurrentAccounts;

        public CurrentAccountRepository(Dictionary<int, CurrentAccount> registeredCurrentAccounts)
        {
            _registeredCurrentAccounts = registeredCurrentAccounts;
        }

        public List<IAccount> ListRegisteredAccounts()
        {
            return _registeredCurrentAccounts.Select(q => q.Value).ToList<IAccount>();
        }
        public CurrentAccount GetAccountByNumber(int accountNumber)
        {
            if (_registeredCurrentAccounts.ContainsKey(accountNumber))
            {
                return _registeredCurrentAccounts[key: accountNumber];
            }
            else
            {
                throw new AccoutnNotFoundException("The number account was not found in the registered account's dictionary");
            }
        }
        public void Attemp(CurrentAccount account)
        {
            _registeredCurrentAccounts.Add(account.AccountNumber, account);
        }
    }
}
