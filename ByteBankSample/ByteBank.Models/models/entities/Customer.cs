using System;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;

namespace ByteBankLib.Models.Entities
{
	public class Customer
	{
		public int Id { get; private set; }
        public string Name { get;}
		public int Cpf { get;}
		public CustomerLevelEnum CustomerLevel { get; private set; } //Change to Enum
        public string Status { get; private set; }
        public DateTime AssectionDate { get; }

        public Customer(int id, string name, int cpf, CustomerLevelEnum customerLevel, string status)
		{
			Id = id;
			Name = name;
			Cpf = cpf;
			CustomerLevel = customerLevel;
			Status = status;
			AssectionDate = DateTime.Now;
		}

		public Customer(int id, string name, int cpf)
		{
			Id = id;
			Name = name;
			Cpf = cpf;
		}

		public void Unactivate()
        {
			this.Status = "inactive";
        }

		public void Promote()
        {
			if(CustomerLevel == CustomerLevelEnum.PremiumCustomer)
            {
				throw new CustomerPromotionLimitExcededException("This customer was already promoted to the max customer level");
            }
			this.CustomerLevel++;

        }
	}
}
