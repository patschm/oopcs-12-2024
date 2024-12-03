using System.IO;

namespace Tekenen;

class Rechthoek : Figuur
{
    private int _hoogte;
    private int _breedte;

    public int Breedte
    {
        get { return _breedte; }
        set
        {
            if (value >= 0) _breedte = value;
        }
    }
    public int Hoogte
    {
        get { return _hoogte; }
        set
        {
            if (value >= 0) _hoogte = value;
        }
    }
    public override void Teken()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"Rechthoek met hoogte {Hoogte} en breedte {Breedte}");
    }

    protected override double BerekenOppervlak()
    {
        return Hoogte * Breedte;
    }
}
