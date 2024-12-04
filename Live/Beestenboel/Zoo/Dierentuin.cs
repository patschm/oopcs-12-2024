using Zoo.Verblijven;

namespace Zoo;

internal class Dierentuin
{
    private Verblijf[] verblijven = new Verblijf[10];

    public void Add(Verblijf verblijf)
    {
        for (int i = 0; i < verblijven.Length; i++)
        {
            if (verblijven[i] == null)
            {
                verblijven[i] = verblijf;
                return;
            }
        }
    }

    public void Open()
    {
        foreach(Verblijf verblijf in verblijven)
        {
            verblijf?.Rammel();
        }
    }
}
