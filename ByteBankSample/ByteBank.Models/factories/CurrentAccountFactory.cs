using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;


namespace ByteBankLib.Factories
{
    public class CurrentAccountFactory: ICurrentAccountFactory
    {
        private ICurrentAccountRepository _currentAccountRepository;

        public CurrentAccountFactory(ICurrentAccountRepository currentAccountRepository)
        {
            _currentAccountRepository = currentAccountRepository;
        }

        public CurrentAccount GetNew(Customer principal, Double initialBalance)
        {
            Random randomizer = new Random();
            CurrentAccount ac = new CurrentAccount(
                                        principal, 
                                        AccountDataGeneratorHelper.GetAccountNumber(),
                                        AccountDataGeneratorHelper.GetAccountSortCode(),
                                        initialBalance
                                    );
            _currentAccountRepository.Attemp(ac);

            return ac;
        }
    }
}
