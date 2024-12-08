using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_OCP
{
	public class CreditCardPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing credit card payment of {amount}");
		}
	}

	

}
