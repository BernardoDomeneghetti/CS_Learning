
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Repository
{
    public static class CurrentAccountRepository
    {
        public static Dictionary<int, CurrentAccount>RegisteredCurrentAccounts{ get; set; }
        public static List<IAccount> ListRegisteredAccounts()
        {
            return RegisteredCurrentAccounts.Select(q => q.Value).ToList<IAccount>();
        }
        public static CurrentAccount GetAccountByNumber(int accountNumber)
        {
            if (RegisteredCurrentAccounts.ContainsKey(accountNumber))
            {
                return RegisteredCurrentAccounts[key: accountNumber];
            }
            else
            {
                throw new AccoutnNotFoundException("The number account was not found in the registered account's dictionary");
            }
        }
    }
}
