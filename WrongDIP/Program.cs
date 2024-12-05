public class EMailService
{
	public void SendEmail(string mail)
	{
		Console.WriteLine("Mail: " + mail +	"/nGönderildi");
	}
}

public class NotificationManager
{
	EMailService eMailService = new EMailService(); //bağımlılık bunun yerine Interface kullan
	public void Notify(string message)
	{
		eMailService.SendEmail(message);
		Console.WriteLine("Mail Gönderildi.");
	}
}