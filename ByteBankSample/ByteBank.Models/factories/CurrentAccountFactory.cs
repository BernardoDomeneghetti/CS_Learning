using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;


namespace ByteBankLib.Factories
{
    public class CurrentAccountFactory
    {
        public static CurrentAccount GetNumberedCurrentAccount(Customer principal, Double initialBalance)
        {
            Random randomizer = new Random();
            CurrentAccount ac = new CurrentAccount(
                                        principal, 
                                        AccountDataGeneratorHelper.GetAccountNumber(),
                                        AccountDataGeneratorHelper.GetAccountSortCode(),
                                        initialBalance
                                    );
            CurrentAccountRepository.RegisteredCurrentAccounts.Add(ac.AccountNumber, ac);

            return ac;
        }
    }
}
