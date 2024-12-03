
namespace Tekenen;

class Cirkel : Figuur
{
    private float _straal;

    public float Straal
    {
        get { return _straal; }
        set
        {
            if (value >= 0) _straal = value;
        }
    }

    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Cirkel met straal {Straal}");
    }

    protected override double BerekenOppervlak()
    {
        return Math.PI * Math.Pow(Straal, 2);
    }
}
