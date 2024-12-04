using Zoo.Dieren;

namespace Zoo.Verblijven;

internal class Steppe : Verblijf
{
    protected override bool Check(Dier dier)
    {
        return dier is Herbivoor;
    }
}
