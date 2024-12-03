namespace DeLampenFabriek;

internal class Program
{
    static void Main(string[] args)
    {
        // Virtuele universum. Hier leven je objecten
        // Big bang

        Lamp l1 = new Lamp();
        //l1.intensiteit = 100;
        l1.Kleur = ConsoleColor.Yellow;

        Lamp l2 = new Lamp(300, ConsoleColor.Green);
        //l2.intensiteit = 300;
        //l2.kleur = ConsoleColor.Green;

        l1.Aan();
        Console.WriteLine("En verder");
        l1.Uit();

        l2.Aan();
        Console.WriteLine("We schrijven nog meer");
        l2.Uit();


        Lamp x3 = new Lamp(1000, ConsoleColor.Cyan);
        // x3.intensiteit = -1000;
        //x3.SetIntensiteit(-1000);
        x3.Intensiteit = -1000; 
        Console.WriteLine(x3.Intensiteit);
        x3.Aan();
        Console.WriteLine("Heel helder");
        x3.Uit();

        // Property Initializers
        Lamp x42 = new Lamp { 
           Intensiteit = 2000, 
           Kleur=ConsoleColor.Magenta 
        };

        x42.Aan();
        Console.WriteLine("Superlamp");

        // Big Crunch
    }
}

