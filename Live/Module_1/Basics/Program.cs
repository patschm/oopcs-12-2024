namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        // Typenaam variabelenaam;
        int age = 42;
        {
            string name = "Jan";
            Console.WriteLine(age);
        }
        char letter = 'A';
        sbyte iets = 127;
        //string name;

        // Console.WriteLine(name);
        //int result = age + 3;

        //age = age + 4;
        //age += 4;
        //age += 1;

        Console.WriteLine(++age);
        Console.WriteLine(age);

        float res = 5 / 2F;

        Console.WriteLine(res);

        bool res1 = false && age > 50;


        int res3 = 1 ^ 3;

        // 0001
        // 0011

        Console.WriteLine(res3);

        string? s = null;
        int? a = null;

        //if (a.HasValue)
            Console.WriteLine(a ?? 42);
        //else
        // Console.WriteLine(42);

        //if (s != null)
            Console.WriteLine(s?.Length); // 

        Console.WriteLine("Eind");
    }
}
