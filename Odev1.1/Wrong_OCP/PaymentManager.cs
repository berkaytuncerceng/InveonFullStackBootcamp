using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrong_OCP
{
	public class PaymentManager
	{
		public void ProcessPayment(string paymentType, decimal amount)
		{
			if (paymentType == "CreditCard")
			{
				Console.WriteLine($"Processing credit card payment of {amount}");
			}
			else if (paymentType == "PayPal")
			{
				Console.WriteLine($"Processing PayPal payment of {amount}");
			}
			else
			{
				Console.WriteLine("Unsupported payment type");
			}
		}
	}
}
