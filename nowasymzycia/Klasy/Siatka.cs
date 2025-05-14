namespace nowasymzycia.Klasy;

public class Siatka
{
    private int[,] _tablicaKomorek;

    private const int Zywa = 1;
    private const int Martwa = 0;


    public Siatka(int[,] tablicaPoczatkowa, int liczbaKolumn, int liczbaWierszy)
    {
        _tablicaKomorek = new int[liczbaWierszy, liczbaKolumn];
        
        Random random = new Random();
        
        for (int i = 0; i < tablicaPoczatkowa.GetLength(0); i++)
        {
            for (int j = 0; j < tablicaPoczatkowa.GetLength(1); j++)
            {
                _tablicaKomorek[i, j] = tablicaPoczatkowa[i, j];
            }
        }
    }

    public void ZrobKrok()
    {
        int[,] noweKomorki = new int[_tablicaKomorek.GetLength(0), _tablicaKomorek.GetLength(1)];

        for (int i = 0; i < _tablicaKomorek.GetLength(0); i++)
        {
            for (int j = 0; j < _tablicaKomorek.GetLength(1); j++)
            {
                noweKomorki[i, j] = ZastosujZasady(i, j);
            }
        }
        
        _tablicaKomorek = noweKomorki;
    }

    private int PoliczZywychSasiadow(int nrRzedu, int nrKolumny)
    {
        int licznik = 0;

        for (int i = nrRzedu - 1; i <= nrRzedu + 1; i++)
        {
            for (int j = nrKolumny - 1; j <= nrKolumny + 1; j++)
            {
                if (
                    i >= 0
                    && i < _tablicaKomorek.GetLength(0)
                    && j >= 0
                    && j < _tablicaKomorek.GetLength(1)
                    && !(i == nrRzedu && j == nrKolumny))
                {
                    if (_tablicaKomorek[i, j] == Zywa)
                    {
                        licznik++;
                    }
                }
            }
        }

        return licznik;
    }

    // jeśli martwa oraz ma 3 żywych sąsiadów, to staje się żywa
    // jeśli żywa oraz ma 2 albo 3 żywych sąsiadów, to pozostaje żywa. Przy innej
    // liczbie sąsiadów staje się martwa

    private int ZastosujZasady(int nrRzedu, int nrKolumny)
    {
        int liczbaSasiadow = PoliczZywychSasiadow(nrRzedu, nrKolumny);

        if (_tablicaKomorek[nrRzedu, nrKolumny] == Zywa)
        {
            if (liczbaSasiadow == 3 || liczbaSasiadow == 2)
            {
                return Zywa;
            }
        }
        else
        {
            if (liczbaSasiadow == 3)
            {
                return Zywa;
            }
        }

        return Martwa;
    }

    public void Wydrukuj()
    {
        string wydruk = new string('-', _tablicaKomorek.GetLength(1) *2) + "\n";
        
        for (int i = 0; i < _tablicaKomorek.GetLength(0); i++)
        {
            for (int j = 0; j < _tablicaKomorek.GetLength(1); j++)
            {
                if (_tablicaKomorek[i, j] == Zywa)
                {
                    wydruk += "O";
                }
                else
                {
                    wydruk += " ";
                }

                wydruk += " ";
            }

            wydruk += "|\n";
        }

        wydruk += new string('-', _tablicaKomorek.GetLength(1) * 2);
        Console.WriteLine(wydruk);
    }
    
}