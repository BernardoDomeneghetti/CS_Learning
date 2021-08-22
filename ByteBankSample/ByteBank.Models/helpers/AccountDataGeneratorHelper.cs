using System;

namespace ByteBank.models
{
    public static class AccountDataGeneratorHelper
    {
        public static Int32 getAccountNumber()
        {
            Random randomizer = new Random();
            return randomizer.Next();
        }
        public static Int32 getAccountSortCode()
        {
            Random randomizer = new Random();
            return randomizer.Next();
        }
    }
}
