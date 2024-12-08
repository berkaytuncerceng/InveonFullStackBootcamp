public interface IArac
{
	void Sur();
	void CamlariAc();
	void HavaYastigiCalistir();
}

public interface ISarjEt
{
	void SarjEt();
}

public interface IYakitDoldur
{
	void YakitDoldur();
}

public class BenzinliArac : IArac, IYakitDoldur
{
	public void Sur()
	{
		Console.WriteLine("Benzinli araç sürülüyor.");
	}

	public void YakitDoldur()
	{
		Console.WriteLine("Benzin dolduruluyor.");
	}

	public void CamlariAc()
	{
		Console.WriteLine("Benzinli araç camları açılıyor.");
	}

	public void HavaYastigiCalistir()
	{
		Console.WriteLine("Benzinli araç hava yastığı çalıştırılıyor.");
	}
}

public class ElektrikliArac : IArac, ISarjEt
{
	public void Sur()
	{
		Console.WriteLine("Elektrikli araç sürülüyor.");
	}

	public void SarjEt()
	{
		Console.WriteLine("Elektrikli araç şarj ediliyor.");
	}

	public void CamlariAc()
	{
		Console.WriteLine("Elektrikli araç camları açılıyor.");
	}

	public void HavaYastigiCalistir()
	{
		Console.WriteLine("Elektrikli araç hava yastığı çalıştırılıyor.");
	}
}

public class HidrolikArac : IArac
{
    public void Sur()
    {
        Console.WriteLine("Hidrolik araç sürülüyor.");
    }

    public void CamlariAc()
    {
        Console.WriteLine("Hidrolik araç camları açılıyor.");
    }

    public void HavaYastigiCalistir()
    {
        Console.WriteLine("Hidrolik araç hava yastığı çalıştırılıyor.");
    }
}
