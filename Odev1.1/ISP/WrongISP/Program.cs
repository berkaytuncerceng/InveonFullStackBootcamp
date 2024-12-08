public interface IArac
{
	void Sur();
	void YakitDoldur();
	void SarjEt();
	void CamlariAc();
	void HavaYastigiCalistir();
}

public class BenzinliArac : IArac
{
	public void Sur()
	{
		Console.WriteLine("Benzinli araç sürülüyor.");
	}

	public void YakitDoldur()
	{
		Console.WriteLine("Benzin dolduruluyor.");
	}

	public void SarjEt()
	{
		throw new NotImplementedException("Benzinli araçlar şarj edilemez.");
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

public class ElektrikliArac : IArac
{
	public void Sur()
	{
		Console.WriteLine("Elektrikli araç sürülüyor.");
	}

	public void YakitDoldur()
	{
		throw new NotImplementedException("Elektrikli araçlarda yakıt doldurma işlemi yok.");
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

	public void YakitDoldur()
	{
		Console.WriteLine("Hidrolik araç yakıt dolduruluyor.");
	}

	public void SarjEt()
	{
		throw new NotImplementedException("Hidrolik araçlar şarj edilemez.");
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
