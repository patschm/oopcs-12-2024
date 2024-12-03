namespace Overerving;

// Bouwlamp erft van Lamp
class BouwLamp : Lamp
{
    public int GloeiTijd { get; set; }

    public override  void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De bouwlamp gloeit {GloeiTijd}seconden op");
        Console.WriteLine($"De bouwlamp is aan en brandt met {Intensiteit} lm");
    }
    public override void Uit()
    {
        Console.WriteLine("De bouwlamp gaat uit");
        Console.ResetColor();
    }

}
