using Right_OCP;

class Program
{
	static void Main(string[] args)
	{
		var paymentManager = new PaymentManager();

		IPayment creditCardPayment = new CreditCardPayment();
		paymentManager.ProcessPayment(creditCardPayment, 100.00m);

		IPayment payPalPayment = new PayPalPayment();
		paymentManager.ProcessPayment(payPalPayment, 200.00m);

		IPayment bankTransferPayment = new BankTransferPayment();
		paymentManager.ProcessPayment(bankTransferPayment, 300.00m);
	}
}
