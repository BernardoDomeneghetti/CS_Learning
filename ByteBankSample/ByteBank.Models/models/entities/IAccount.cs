using System;
using System.Collections.Generic;


namespace ByteBankLib.Models.Entities
{
    public interface IAccount
    {
        public void Deposit(Double value);
        public void Withdraw(Double value);
    }
}
