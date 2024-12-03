namespace Overerving;

// TL Erft van Lamp
// Stel jezelf altijd de vraag: "Is het een?"
// Is TL een Lamp? Ja!
class TL : Lamp
{
    public int StarterTijd { get; set; } = 3;

    // Met override maak ik dir gedrag nu polymorf.
    // Kan natuurlijk alleen als Aan() virtual
    public override void Aan()
    {      
        for (int i = 0; i < StarterTijd; i++)
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"Knipper knipper ({StarterTijd} keer)");
            Task.Delay(200).Wait();
            Console.ResetColor();
            Console.Clear();
        }
        Console.BackgroundColor = Kleur;        
        Console.WriteLine($"De TL is aan en brandt met {Intensiteit} lm");
    }
    public override  void Uit()
    {
        Console.WriteLine("De TL gaat uit");
        Console.ResetColor();
    }
}
