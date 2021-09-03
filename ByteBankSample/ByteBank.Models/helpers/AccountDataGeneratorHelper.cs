using System;

namespace ByteBankLib.Helpers
{
    public static class AccountDataGeneratorHelper
    {
        public static Int32 GetAccountNumber()
        {
            Random randomizer = new Random();
            return randomizer.Next();
        }
        public static Int32 GetAccountSortCode()
        {
            Random randomizer = new Random();
            return randomizer.Next();
        }
    }
}
