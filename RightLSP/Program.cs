public interface IHareketEt
{
	void HareketEt();
}

public interface ISesCikar
{
	void SesCikar();
}

public class Kedi : IHareketEt, ISesCikar
{
	public void HareketEt()
	{
		Console.WriteLine("Kedi hareket ediyor.");
	}

	public void SesCikar()
	{
		Console.WriteLine("Miyav");
	}
}

public class Kopek : IHareketEt, ISesCikar
{
	public void HareketEt()
	{
		Console.WriteLine("Köpek koşuyor.");
	}

	public void SesCikar()
	{
		Console.WriteLine("Havhav");
	}
}

public class Balik : IHareketEt
{
	public void HareketEt()
	{
		Console.WriteLine("Balık yüzer.");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		List<IHareketEt> hareketEdenHayvanlar = new List<IHareketEt>
		{
			new Kedi(),
			new Kopek(),
			new Balik()
		};

		foreach (var hayvan in hareketEdenHayvanlar)
		{
			hayvan.HareketEt();
		}

		List<ISesCikar> sesCikaranHayvanlar = new List<ISesCikar>
		{
			new Kedi(),
			new Kopek()
		};

		foreach (var hayvan in sesCikaranHayvanlar)
		{
			hayvan.SesCikar();
		}
	}
}
