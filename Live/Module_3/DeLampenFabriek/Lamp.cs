namespace DeLampenFabriek;

// Dit is de blauwdruk van het object (Lamp in dit geval)
// Dit is een Custom type
class Lamp
{
    // Eigenschappen van de lamp sla ik op in fields
    // Fields zijn veredelde variabelen.
    // By default zijn die private
    private int _intensiteit = 100;
    //private ConsoleColor _kleur;

    // cplusplus-iaans
    //public void SetIntensiteit(int wdeerer)
    //{
    //    if (wdeerer >= 0 && wdeerer < 5000)
    //    {
    //        this.intensiteit = wdeerer;
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return this.intensiteit;
    //}

    // Een dotnetter gebruikt properties.
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
    // Auto-generating property. Genereert zijn eigen private field.
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;


    // Gedrag leg ik vast in functies of procedures.
    // Die noemen we dan Methods
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is aan en brandt met {Intensiteit} lm");
    }
    public void Uit()
    {
        Console.WriteLine("De lamp gaat uit");
        Console.ResetColor();
    }

    // Constructors
    // Is bedoeld om fields een initiele waarde te geven
    // Als jij er geen defineert, genereert de compiler er een. (default constructor)
    // Zijn niet altijd nog. Alleen als je van buitenaf een waarde EIST
    public Lamp()
    {
        //Console.WriteLine("Default constructor");
        Intensiteit = 100;
        Kleur = ConsoleColor.Yellow;
    }
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        //SetIntensiteit(intensiteit);
        Intensiteit = intensiteit;
        Kleur = kleur;
    }
}
