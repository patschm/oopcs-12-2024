
namespace RaadHetGetal;

internal class Program
{
    static void Main(string[] args)
    {
        string player = VraagNaam();
        int teRadenGetal = RandomGetal(0, 10);
        int poging;
        for (poging = 0; poging < 5; poging++)
        {
            int nr = VraagGetal();
            bool geraden = EvalueerGetal(nr, teRadenGetal);
            if (geraden)
            {
                ToonGeraden(player);
                break;
            }
        }
        if (poging == 5)
        {
            ToonNietGeraden(player, teRadenGetal);
        }
    }

    static void ToonNietGeraden(string player, int teRadenGetal)
    {
        Console.WriteLine($"Helaas {player}. Je hebt het getal {teRadenGetal} niet geraden");
    }

    static void ToonGeraden(string player)
    {
        Console.WriteLine($"Gefeliciteerd {player}. Je hebt het getal geraden");
    }

    static bool EvalueerGetal(int nr, int teRadenGetal)
    {
        if (nr > teRadenGetal)
        {
            Console.WriteLine($"{nr} is te groot");
            return false;
        }
        if (nr < teRadenGetal)
        {
            Console.WriteLine($"{nr} is te klein");
            return false;
        }
        return true;
    }

    static int VraagGetal()
    {
        do
        {
            Console.WriteLine("Geef een getal");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int nr))
            {
                return nr;
            }
        }
        while (true);
    }

    static int RandomGetal(int min, int max)
    {
       return Random.Shared.Next(min, max);
    }

    static string VraagNaam()
    {
        Console.WriteLine("Geef uw naam");
        return Console.ReadLine();
    }
}
