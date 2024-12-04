using Zoo.Dieren;

namespace Zoo.Verblijven;

internal class Aquarium : Verblijf
{
    protected override bool Check(Dier dier)
    {
        return dier is Vis;
    }
}
