using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_OCP
{
	public class PaymentManager
	{
		public void ProcessPayment(IPayment payment, decimal amount)
		{
			payment.ProcessPayment(amount);
		}
	}
}
