public class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan bir ses çıkarıyor.");
    }
}

public class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav!");
    }
}

public class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav!");
    }
}

public class Balik : Hayvan
{
    public override void SesCikar()
    {
        throw new NotImplementedException("Balık ses çıkarmaz.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Hayvan> hayvanlar = new List<Hayvan>
        {
            new Kedi(),
            new Kopek(),
            new Balik()
        };

        foreach (var hayvan in hayvanlar)
        {
            hayvan.SesCikar(); 
        }
    }
}
