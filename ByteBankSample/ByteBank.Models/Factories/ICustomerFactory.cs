using System;
using ByteBankLib.Models.Entities;
using ByteBankLib.Helpers;
using ByteBankLib.Repository;
using ByteBankLib.Models.Enums;

namespace ByteBankLib.Factories
{
    public interface ICustomerFactory
    {
        public Customer GetNew(string name, int cpf, CustomerLevelEnum customerLevel, string status);
    }
}
