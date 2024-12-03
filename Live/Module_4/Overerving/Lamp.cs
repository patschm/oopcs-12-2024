namespace Overerving;

abstract class Lamp
{
    // public: public members kan men overal benaderen.
    // private: private members kunnen alleen benaderd worden vanuit de class zelf.
    // protected: protected members kunnen vanuit de class zelf en afgeleide classen benaderd worden.
    private int _intensiteit = 100;
    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value < 5000)
            {
                _intensiteit = value;
            }
        }
    }
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Met Virtual geef ik aan dat dit GEDRAG polymorf KAN zijn.
    // Een afgeleide class mag overriden als hij dat wil.
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is aan en brandt met {Intensiteit} lm");
    }
    // Met abstract MOET een afgeleide class overriden
    // Dit leidt ertoe dat mijn hele class abstract wordt.
    public abstract void Uit();
    //{
    //    Console.WriteLine("De lamp gaat uit");
    //    Console.ResetColor();
    //}
}
