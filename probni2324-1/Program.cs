using probni2324_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Film f1 = new Film("Film 1", 3.215M, 124),
     f2 = new Film("Film 2", 3.174M, 126);
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        try
        {
            Film f3 = new Film("Film 3", -2.3M, 125);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        Serija s1 = new Serija("Serija 1", 2M);
        s1["Prva epizoda"] = 86;
        s1["Prva epizoda"] = 92; //ovo nema nikakvog efekta
        s1["Druga epizoda"] = 124;
        Console.WriteLine(s1);

        List<Film> filmovi = new List<Film>()
        {
            f1, f2
        };
        filmovi.Sort();
        Kolekcija<Film> f = new Kolekcija<Film>(filmovi);
        f.Informacije();
        Console.WriteLine("---Mijenjamo cijenu---");
        f1.Cijena = 3.5M;
    }
}