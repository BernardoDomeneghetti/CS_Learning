using System;

namespace ByteBankLib.Models.Exceptions
{
    public class InvalidDepositException : Exception
    {
        public InvalidDepositException() { }
        public InvalidDepositException(string message) : base(message) { }
    }
    public class InvalidAccountRegistrationDataException : Exception
    {
        public InvalidAccountRegistrationDataException() { }
        public InvalidAccountRegistrationDataException(string message) : base(message) { }
    }
    public class InvalidWithdrawException : Exception
    {
        public InvalidWithdrawException() { }
        public InvalidWithdrawException(string message) : base(message) { }
    }
}
