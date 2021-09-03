using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;


namespace ByteBankLib.Factories
{
    class CurrentAccountFactory
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

            return ac;
        }
    }
}
