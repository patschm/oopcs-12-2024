using Zoo.Dieren;

namespace Zoo.Verblijven;

internal class Kooi : Verblijf
{
    protected override bool Check(Dier dier)
    {
        return dier is Kat;
    }
}
