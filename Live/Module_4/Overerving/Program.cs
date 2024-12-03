namespace Overerving;

internal class Program
{
    static void Main(string[] args)
    {
        // Generaliseren.
        Lamp lamp1 = new TL
        {
            Kleur = ConsoleColor.Yellow,
            Intensiteit = 200,
            StarterTijd = 4
        };

        // Leg het vergrootglas op lamp1 en je ziet zijn specifieke eigenschappen weer.
        // Zo weinig mogelijk gebruiken.
       // Console.WriteLine((lamp1 as TL).StarterTijd);

        ZetAanEnUit(lamp1);
        //lamp1.Aan();
        //lamp1.Uit();

        Lamp lamp2 = new BouwLamp
        {
            Kleur = ConsoleColor.Cyan,
            Intensiteit = 2000,
            GloeiTijd = 60
        };
        // Lamp lmp = lamp2 
        ZetAanEnUit(lamp2);
        //lamp2.Aan();
        //lamp2.Uit();

        //Lamp lamp3 = new Lamp
        //{
        //    Kleur = ConsoleColor.Red,
        //    Intensiteit = 300
        //};
        //ZetAanEnUit(lamp3);
    }


    static void ZetAanEnUit(Lamp lmp)
    {
        lmp.Aan();
        lmp.Uit();
    }
    // Overload
    //static void ZetAanEnUit(TL lmp)
    //{
    //    lmp.Aan();
    //    lmp.Uit();
    //}
    // Overload
    //static void ZetAanEnUit(BouwLamp lmp)
    //{
    //    lmp.Aan();
    //    lmp.Uit();
    //}
}
