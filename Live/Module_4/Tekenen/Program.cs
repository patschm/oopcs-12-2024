namespace Tekenen;

internal class Program
{
    static void Main(string[] args)
    {
        Figuur c1 = new Cirkel()
        {
            Straal = 100,
            Kleur = ConsoleColor.DarkBlue
        };

        Figuur r1 = new Rechthoek()
        {
            Hoogte = 100,
            Breedte = 200,
            Kleur = ConsoleColor.Green
        };

        Figuur d1 = new Driehoek
        {
            Hoogte = 100,
            Basis = 200,
            Hoek = 60,
            Kleur = ConsoleColor.Red
        };

        Canvas canv = new Canvas();
        canv.Add(c1);
        canv.Add(r1);
        canv.Add(d1);

        Console.WriteLine($"Oppervlakte cirkel = {c1.Oppervlakte}");
        Console.WriteLine($"Oppervlakte rechthoek = {r1.Oppervlakte}");
        Console.WriteLine($"Oppervlakte driehoek = {d1.Oppervlakte}");

        canv.Refresh();
        //c1.Teken();
        //r1.Teken();
        //d1.Teken();
    }
}
