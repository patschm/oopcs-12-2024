namespace Tekenen;

internal class Program
{
    static void Main(string[] args)
    {
        Figuur c1 = new Figuur("cirkel")
        {
            Straal = 100,
            Kleur = ConsoleColor.DarkBlue
        };

        Figuur r1 = new Figuur("rechthoek")
        {
            Hoogte = 100,
            Breedte = 200,
            Kleur = ConsoleColor.Green
        };

        Figuur d1 = new Figuur("driehoek")
        {
            Hoogte = 100,
            Basis = 200,
            Hoek = 60
        };

        Console.WriteLine($"Oppervlakte cirkel = {c1.Oppervlakte}");
        Console.WriteLine($"Oppervlakte rechthoek = {r1.Oppervlakte}");
        Console.WriteLine($"Oppervlakte driehoek = {d1.Oppervlakte}");

        c1.Teken();
        r1.Teken();
        d1.Teken();
    }
}
