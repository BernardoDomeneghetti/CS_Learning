using System;
using ByteBank.models;

namespace ByteBankSample.factories
{
    class CurrentAccountFactory
    {
        internal static CurrentAccount GetNumberedCurrentAccount(Customer principal, Double initialBalance)
        {
            Random randomizer = new Random();
            CurrentAccount ac = new CurrentAccount(
                                        principal, 
                                        AccountDataGeneratorHelper.getAccountNumber(),
                                        AccountDataGeneratorHelper.getAccountSortCode(),
                                        initialBalance
                                    );

            return ac;
        }
    }
}
