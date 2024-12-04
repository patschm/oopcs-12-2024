using Zoo.Dieren;

namespace Zoo.Verblijven;

internal abstract class Verblijf
{
    private Dier[] dieren = new Dier[10];

    public void Add(Dier d)
    {
        if (Check(d))
        {
            for (int i = 0; i < dieren.Length; i++)
            {
                if (dieren[i] == null)
                {
                    dieren[i] = d;
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine($"!!!! {d.GetType().Name} kan niet in een {this.GetType().Name}");
        }
    }
    protected abstract bool Check(Dier d);
    public virtual void Rammel()
    {
        foreach(Dier d in dieren)
        {
            d?.MaakGeluid();
        }
    }
}
