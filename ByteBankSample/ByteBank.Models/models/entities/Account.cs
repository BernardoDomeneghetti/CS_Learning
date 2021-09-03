using System;
using System.Collections.Generic;
using System.Linq;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Models.Entities
{
    public abstract class Account : IAccount
    {
        public static Dictionary<int, IAccount> RegisteredAccounts { get; protected set; }
        public Customer Principal { get; protected set; }
        public Int32 AccountNumber { get; protected set; }
        public Int32 SortCode { get; protected set; }
        public Double Balance { get; protected set; }
                
        public static List<IAccount> ListRegisteredAccounts()
        {
            return RegisteredAccounts.Select(q => q.Value).ToList<IAccount>();
        }
        public Account(Customer principal, Int32 accountNumber, Int32 sortCode, Double initialBalance)
        {
            if ((sortCode * accountNumber * initialBalance) == 0)
            {
                throw new InvalidAccountRegistrationDataException("One of the informations inserted equals zero, what is not accpeted!");
            }
            this.Principal = principal;
            this.AccountNumber = accountNumber;
            this.SortCode = sortCode;
            this.Balance = initialBalance;
        }
        public void Deposit(Double value)
        {
            if (value > 0)
            {
                this.Balance += value;
            }
            else
                throw new InvalidDepositException("The inserted value is not valid to Deposit, " +
                    "please insert a value bigger then 0 (Zero)");
        }
        public virtual void Withdraw(Double value)
        {
            if (value <= this.Balance && value > 0)
            {
                this.Balance -= value;
            }
            else
            {
                throw new InvalidWithdrawException("ERROR! \n The inserted value is invalid, please insert a valid value!");
            }
        }
    }
}