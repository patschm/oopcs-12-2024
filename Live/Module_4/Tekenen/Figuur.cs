namespace Tekenen;

abstract class Figuur
{
	// Fields
	
	// Properties
	public ConsoleColor Kleur { get; set; } = ConsoleColor.Black;
	public double Oppervlakte
	{
		get
		{
			return BerekenOppervlak();
		}
	}
	// Methods (Gedrag)
	public virtual void Teken()
	{
		Console.ForegroundColor = Kleur;
        Console.WriteLine("Een figuur");
    }
	protected abstract double BerekenOppervlak();
}
