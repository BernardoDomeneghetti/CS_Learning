using System;

namespace ByteBankLib.Helpers
{
    public static class CustomerDataGeneratorHelper
    {
        public static Int32 GetCustomerId()
        {
            Random randomizer = new Random();
            return randomizer.Next();
        }
    }
}
