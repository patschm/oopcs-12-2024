namespace Strafwerk;

internal class Program
{
    static void Main(string[] args)
    {
        for(int tafel = 1; tafel <= 10; tafel++)
        {
            Console.WriteLine($"De tafel van {tafel}");
            for(int teller = 1; teller <= 10; teller++)
            {
                int result = tafel * teller;
                Console.WriteLine($"{teller} x {tafel} = {result}");
            }
        }
    }
}
