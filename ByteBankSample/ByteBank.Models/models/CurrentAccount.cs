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

        /// <summary>
        /// Withdraw method decreases balance's value ultil reaches the account debit limit.
        /// </summary>
        /// <param name="value">Value must be less then <see cref="Account.Balance"/> + <see cref="CurrentAccount.AccountLimit"/></param>
        public override void Withdraw(double value)
        {
            if (value <= Balance + AccountLimit)
            {                
                Balance -= value;
            }

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