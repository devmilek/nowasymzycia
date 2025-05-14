using nowasymzycia.Klasy;

namespace nowasymzycia;

// jeśli martwa oraz ma 3 żywych sąsiadów, to staje się żywa
// jeśli żywa oraz ma 2 albo 3 żywych sąsiadów, to pozostaje żywa. Przy innej
// liczbie sąsiadów staje się martwa

class Program
{
    static void Main(string[] args)
    {
        int[,] szybowiec = new int[3, 3]
        {
            { 0, 1, 0 },
            { 0, 0, 1 },
            { 1, 1, 1 },
        };
        
        int[,] kaczka = new int[5, 5]
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0 },
            { 1, 1, 0, 1, 1 },
            { 1, 1, 1, 1, 0 },
            { 0, 1, 1, 0, 0 }
        };
        
        Gra gra = new Gra(20, 20);
        gra.Uruchom(101);
    }
}