public interface IEMailService
{
	void SendEmail(string mail);
}

public class EmailManager(IEMailService emailService) : IEMailService
{
	public void SendEmail(string mail)
	{
		emailService.SendEmail(mail);
	}
}

public class NotificationManager
{
	IEMailService eMailService; //bağımlılık bunun yerine Interface kullan
	public void Notify(string message)
	{
		eMailService.SendEmail(message);
		Console.WriteLine("Mail Gönderildi.");
	}
}