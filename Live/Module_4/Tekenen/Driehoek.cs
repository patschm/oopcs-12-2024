using System.IO;

namespace Tekenen;

class Driehoek : Figuur
{
    private int _hoek;
    private int _basis;
    private int _hoogte;

    public int Hoogte
    {
        get { return _hoogte; }
        set { _hoogte = value; }
    }
    public int Basis
    {
        get { return _basis; }
        set
        {
            if (value >= 0) _basis = value;
        }
    }
    public int Hoek
    {
        get { return _hoek; }
        set
        {
            if (value >= 0) _hoek = value;
        }
    }
    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Driehoek met basis: {Basis} en hoogte {Hoogte}");
    }

    protected override double BerekenOppervlak()
    {
        return .5 * Basis * Hoogte;
    }
}
