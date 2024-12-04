
namespace Errors;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            do
            {
                int getal = GeefGetal();
                Console.WriteLine(getal);
                Console.WriteLine("Press ESC to quit");
                if (Console.ReadKey().Key == ConsoleKey.F1)
                    WerpZelfEenFoutOp();
                if (Console.ReadKey().Key == ConsoleKey.F2)
                    throw new InsufficientFundsException { MaxAmount = 1200 };
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                Console.Clear();

            }
            while (true);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine($"Je saldo is niet toereikend. Je kunt maar {e.MaxAmount} opnemen");
        }
        catch (Exception ex)
        {
            Console.WriteLine("In de main");
            Console.WriteLine(ex.Message);
        }
    }

    static void WerpZelfEenFoutOp()
    {
        Console.WriteLine("We gaan een fout werpen:");
        //throw new Exception("Ooops
        throw new DivideByZeroException();
    }

    private static int GeefGetal()
    {
        do
        {
            Console.WriteLine("Geef een getal");
            string? snumber = Console.ReadLine();
            try
            {
                int nr = int.Parse(snumber);
                return nr;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Geef nou eens een keer een normaal getal!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HResult);
                Console.WriteLine(e.StackTrace);
            }
            catch(OverflowException) {
                Console.WriteLine($"Getal moet tussen {int.MinValue} en {int.MaxValue} liggen");
            }
            finally
            {
                Console.WriteLine("Wordt altijd uitgevoerd");
            }
        }
        while(true);
    }
}
