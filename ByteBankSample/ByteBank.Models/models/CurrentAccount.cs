using System;

namespace ByteBank.models {
    public class CurrentAccount : Account
    {
        public static Int32 CreatedCurrentAccountAmount;
        public Double AccountLimit { get; private set; }
        public CurrentAccount(
            Customer principal, 
            Int32 accountNumber, 
            Int32 sortCode, 
            Double initialBalance) : 
          base(principal, accountNumber, sortCode, initialBalance)
        {            
            this.AccountLimit = Balance * 0.1;

            CreatedCurrentAccountAmount++;
            CreatedAccountAmount++;
        }

        public void IncreaseLimit(Double IncreaseValue)
        {
            this.AccountLimit += IncreaseValue;
        }

        public void DecraseLimit(Double IncreaseValue)
        {
            this.AccountLimit += IncreaseValue;
        }
    }

}