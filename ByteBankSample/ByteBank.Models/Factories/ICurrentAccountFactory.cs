using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;


namespace ByteBankLib.Factories
{
    public interface ICurrentAccountFactory
    {
        public CurrentAccount GetNew(Customer principal, Double initialBalance);
    }
}
