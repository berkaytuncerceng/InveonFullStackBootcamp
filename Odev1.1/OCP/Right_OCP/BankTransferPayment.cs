using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_OCP
{
	
		public class BankTransferPayment : IPayment
		{
			public void ProcessPayment(decimal amount)
			{
				Console.WriteLine($"Processing bank transfer payment of {amount}");
			}
		}
}
