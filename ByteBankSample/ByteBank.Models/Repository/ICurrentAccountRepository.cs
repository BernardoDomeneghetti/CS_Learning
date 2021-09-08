
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Repository
{
    public interface ICurrentAccountRepository
    {
        public List<IAccount> ListRegisteredAccounts();
        public CurrentAccount GetAccountByNumber(int accountNumber);
        public void Attemp(CurrentAccount account);
    }
}
