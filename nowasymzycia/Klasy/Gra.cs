namespace nowasymzycia.Klasy;

public class Gra
{
    private Siatka _siatka;

    public Gra(int liczbaRzedow, int liczbaKolumn)
    {
        _siatka = new Siatka(liczbaKolumn, liczbaRzedow);
    }

    public void Uruchom(int liczbaIteracji)
    {
        for (int i = 0; i < liczbaIteracji; i++)
        {
            Console.WriteLine($"Itreacja {i}: ");
            _siatka.ZrobKrok();
            _siatka.Wydrukuj();
        }
    }
}