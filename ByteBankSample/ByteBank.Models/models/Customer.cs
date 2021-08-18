namespace ByteBank.models
{
	public class Customer
	{
		private string Name { get; set; }
		private int Cpf { get; set; }
		private int CustomerLevel { get; set; } //Change to Enum
		private string Status { get; set; } 

		public Customer(string name, int cpf, int customerLevel, string status)
		{			
			Name = name;
			Cpf = cpf;
			CustomerLevel = customerLevel;
			Status = status;
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
