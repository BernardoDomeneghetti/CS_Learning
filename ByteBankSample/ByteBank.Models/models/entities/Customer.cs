using System;
namespace ByteBank.models
{
	public class Customer
	{
        public String Name { get;}
		public Int32 Cpf { get;}
		public Int32 CustomerLevel { get; private set; } //Change to Enum
        public String Status { get; private set; }
        public DateTime AssectionDate { get; }



        public Customer(string name, int cpf, int customerLevel, string status)
		{			
			Name = name;
			Cpf = cpf;
			CustomerLevel = customerLevel;
			Status = status;
			AssectionDate = DateTime.Now;
		}

		public Customer(string name, int cpf)
		{		
			Name = name;
			Cpf = cpf;
		}

		public void Unactivate()
        {
			this.Status = "inactive";
        }

		public void Promote()
        {
			this.CustomerLevel++;
        }
	}
}
