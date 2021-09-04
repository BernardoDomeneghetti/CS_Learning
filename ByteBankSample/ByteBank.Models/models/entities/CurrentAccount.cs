using System;
using System.Collections.Generic;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Models.Entities
{
    public class CurrentAccount : Account
    {
        public Double AccountLimit { get; private set; }
        
        public CurrentAccount(
            Customer principal, 
            Int32 accountNumber, 
            Int32 sortCode, 
            Double initialBalance) : 
          base(principal, accountNumber, sortCode, initialBalance)
        {            
            this.AccountLimit = Balance * 0.1;
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