namespace Tekenen;

class Figuur
{
	// Fields
	private string _soort;
	private int _hoogte;
	private int _breedte;
	private float _straal;
	private int _hoek;
	private int _basis;

	// Properties
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
			if (value >= 0)_hoek = value; 
		}
	}
	public float Straal
	{
		get { return _straal; }
		set 
		{ 
			if (value >= 0) _straal = value; 
		}
	}
	public int Breedte
	{
		get { return _breedte; }
		set 
		{
			if (value >= 0)_breedte = value; 
		}
	}
	public int Hoogte
	{
		get { return _hoogte; }
		set 
		{
			if (value >=0) _hoogte = value; 
		}
	}
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Black;
	public double Oppervlakte
	{
		get
		{
			switch(_soort)
			{
				case "cirkel":
					return Math.PI * Math.Pow(Straal, 2);
				case "driehoek":
					return .5 * Basis * Hoogte;
				case "rechthoek":
					return Hoogte * Breedte;
				default:
					return 0;
			}
		}
	}

	// Methods (Gedrag)
	public void Teken()
	{
		Console.ForegroundColor = Kleur;

        switch (_soort)
        {
            case "cirkel":
                Console.WriteLine($"Cirkel met straal {Straal}");
				break;
            case "driehoek":
                Console.WriteLine($"Driehoek met basis: {Basis} en hoogte {Hoogte}");
                break;
            case "rechthoek":
                Console.WriteLine($"Rechthoek met hoogte {Hoogte} en breedte {Breedte}");
				break;
        }
    }

	// Constructor
    public Figuur(string soort)
    {
        _soort = soort;
    }
}
