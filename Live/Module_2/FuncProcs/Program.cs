namespace FuncProcs;

internal class Program
{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Welkomsscherm");
    //    do
    //    {
    //        int a = 0;
    //        string sa;
    //        do
    //        {
    //            Console.WriteLine("Geef getal A");
    //            sa = Console.ReadLine();
    //            if (int.TryParse(sa, out int result))
    //            {
    //                a = int.Parse(sa);
    //                break;
    //            }
    //        }
    //        while (true);            
            
    //        string sb;
    //        int b = 0;
    //        do
    //        {
    //            Console.WriteLine("Geef getal B");
    //            sb = Console.ReadLine();
    //            if (int.TryParse(sa, out int r))
    //            {
    //                b = int.Parse(sb);
    //                break;
    //            }
    //        }
    //        while (true);

    //        int res = a + b;
    //        Console.WriteLine($"{a} + {b} = {res}");

    //        Console.WriteLine("Nog een berekening? (ESC for quit)");
    //        ConsoleKeyInfo k = Console.ReadKey();
    //        if (k.Key == ConsoleKey.Escape) break;

    //    }
    //    while(true);
    //    Console.WriteLine("Nou, tot de volgende keer maar weer");

    //}

    static void Main()
    {
        ToonWelkomsScherm();
        do
        {
            int a = VraagGetal("A");
            int b = VraagGetal("B");
            int result = TelOp(a, b);
            ToonOptelling(a, b, result);
            if (CanQuit())
            {
                break;
            }
        }
        while(true);
        ToonAfscheidsScherm();
    }

    // Dit is een procedure. Herkenbaar aan void ervoor.
    static void ToonWelkomsScherm()
    {
        Console.WriteLine("Welkomsscherm");
    }

    // Dit is een functie. Herkenbaar aan NIET void ervoor.
    static int VraagGetal(string label)
    {
        string s;
        int b = 0;
        do
        {
            Console.WriteLine($"Geef getal {label}");
            s = Console.ReadLine();
            
            if (CanConvert(s))
            {
                b = ConvertToNumber(s);
                break;
            }
        }
        while (true);
        return b;
    }

    static bool CanConvert(string s)
    {
        bool b = int.TryParse(s, out int r);
        return b;
    }
    static int ConvertToNumber(string s)
    {
        int b = int.Parse(s);
        return b;
    }
    static void ToonOptelling(int a, int b, int result)
    {
        Console.WriteLine($"{a} + {b} = {result}");
    }
    static int TelOp(int a, int b)
    {
        return a + b;
    }

    static bool CanQuit()
    {
        Console.WriteLine("Nog een berekening? (ESC for quit)");
        ConsoleKeyInfo k = Console.ReadKey();
        return k.Key == ConsoleKey.Escape;
        //bool canQuit = k.Key == ConsoleKey.Escape;
        ///return canQuit;
    }
    static void ToonAfscheidsScherm()
    {
        Console.WriteLine("Nou, tot de volgende keer maar weer");
    }
}
