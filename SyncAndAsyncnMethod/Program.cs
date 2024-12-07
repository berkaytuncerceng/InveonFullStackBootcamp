using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		string path = @"C:\Users\berka\OneDrive\Masaüstü\coplugum\Yeni Metin Belgesi.txt";

		Program program = new Program();
		Console.WriteLine("Senkron dosya okuma işlemi");
		ReadFile(path);

		Console.WriteLine("\nAsenkron okuma işlemi");
		await ReadFileAsync(path);
		await Task.Delay(1000);
	
		

		Console.WriteLine("Tüm işlemler tamamlandı");
		Console.ReadLine();
	}

	public static void ReadFile(string path)
	{
		using (var reader = new StreamReader(path))
		{
			Console.WriteLine("Dosya içeriği (senkron):");
			Console.WriteLine(reader.ReadToEnd());
		}
	}

	public static async Task ReadFileAsync(string path)
	{
		using (var reader = new StreamReader(path))
		{
			Console.WriteLine("Dosya içeriği (asenkron):");
			string content = await reader.ReadToEndAsync(); // Dosya içeriğini asenkron oku
			Console.WriteLine(content);
		}
	}
}
