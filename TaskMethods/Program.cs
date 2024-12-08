using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Dosya okuma başlatılıyor...");
		string filePath = @"C:\Users\berka\OneDrive\Masaüstü\example.txt";
		string content = await Task.Run(() => ReadFile(filePath));

		Console.WriteLine("Dosya içeriği:");
		Console.WriteLine(content);

		await ExampleDelay();
		await ExampleFromResult();
		await ExampleWhenAll();
		await ExampleWhenAny();
	}

	static string ReadFile(string path)
	{
		// Dosya okuma işlemi simüle ediliyor
		if (File.Exists(path))
		{
			return File.ReadAllText(path); // Dosya içeriğini okur
		}
		else
		{
			return "Dosya bulunamadı.";
		}
	}

	static async Task ExampleDelay()
	{
		Console.WriteLine("Başla");
		await Task.Delay(2000); // 2 saniye bekle
		Console.WriteLine("2 saniye sonra işlem devam ediyor...");
	}

	static Task<int> GetNumber()
	{
		return Task.FromResult(42); // Hızlı bir şekilde bir değer döndürüyor
	}

	static async Task ExampleFromResult()
	{
		int result = await GetNumber();
		Console.WriteLine($"Sonuç: {result}");
	}

	static async Task ExampleWhenAll()
	{
		var task1 = Task.Run(() => Console.WriteLine("Görev 1"));
		var task2 = Task.Run(() => Console.WriteLine("Görev 2"));
		var task3 = Task.Run(() => Console.WriteLine("Görev 3"));

		await Task.WhenAll(task1, task2, task3);
		Console.WriteLine("Tüm görevler tamamlandı.");
	}

	static async Task ExampleWhenAny()
	{
		var task1 = Task.Delay(3000);
		var task2 = Task.Delay(2000);
		var task3 = Task.Delay(1000);

		Task completedTask = await Task.WhenAny(task1, task2, task3);
		Console.WriteLine("Bir görev tamamlandı.");
	}

	static async Task ExampleFromException()
	{
		try
		{
			Console.WriteLine("Hata oluşturacak göreve başlanıyor...");
			int result = await GetNumberAsync(0); // 0 göndererek hata oluşmasını sağlıyoruz
			Console.WriteLine($"Sonuç: {result}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Hata yakalandı: {ex.Message}");
		}
	}

	static Task<int> GetNumberAsync(int divisor)
	{
		if (divisor == 0)
		{
			return Task.FromException<int>(new DivideByZeroException("Sıfıra bölme hatası!"));
		}

		int result = 42 / divisor; // Örnek işlem
		return Task.FromResult(result); // Hata yoksa sonucu döndür
	}
}
