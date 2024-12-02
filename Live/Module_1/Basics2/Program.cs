namespace Basics2;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        if (x > 10)
        {
            //int y = 20;
            Console.WriteLine("Indien true");
        }
        else
        {
            Console.WriteLine("Indien false");
        }

        switch(x)
        {
            case 9:
            case 10:
                Console.WriteLine("Tien");
                break;
            default:
                Console.WriteLine("Iets anders");
                break ;
        }

        int y = 20;
        for (;  ; )
        {
            y = y + 1;
            if (y == 25) continue;
            if (y == 30) break;
            Console.WriteLine($"Iets {y}");
        }
        //Console.WriteLine(y);

        // Wordt 1 of meer keer uitgevoerd
        do
        {
            Console.WriteLine($"Heel Anders {y}");
            y = y + 1;
        }
        while (y < 30);

        // Wordt 0 of meer keer uitgevoerd
        while(y < 30)
        {
            Console.WriteLine($"Anders {y}");
            y = y + 1;
        }
    }
}
