using nowasymzycia.Klasy;

namespace nowasymzycia;

// jeśli martwa oraz ma 3 żywych sąsiadów, to staje się żywa
// jeśli żywa oraz ma 2 albo 3 żywych sąsiadów, to pozostaje żywa. Przy innej
// liczbie sąsiadów staje się martwa

class Program
{
    static void Main(string[] args)
    {
        Gra gra = new Gra(20, 20);
        gra.Uruchom(101);
    }
}