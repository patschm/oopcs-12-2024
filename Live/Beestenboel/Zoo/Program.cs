
using System.Linq.Expressions;
using Zoo.Dieren;
using Zoo.Verblijven;

namespace Zoo;

internal class Program
{
    static void Main(string[] args)
    {
        Dierentuin zoo = Create();
        zoo.Open();
    }

    static Dierentuin Create()
    {
        var zoooo = new Dierentuin();
        var kooi = new Kooi();
        var step = new Steppe();
        var aquarium = new Aquarium();
        zoooo.Add(aquarium);
        zoooo.Add(step);
        zoooo.Add(kooi);

        var clown = new Clownsvis();
        var sidder = new Sidderaal();
        var maan = new Maanvis();
        var tijger = new Tijger();
        var leeuw = new Leeuw();
        var poema = new Poema();
        var wild = new Wildebeest();
        var zebra = new Zebra();
        var giraf = new Giraffe();

        aquarium.Add(clown);
        aquarium.Add(leeuw);
        aquarium.Add(maan);
        aquarium.Add(sidder);

        kooi.Add(leeuw);
        kooi.Add(maan);
        kooi.Add(tijger);
        kooi.Add(poema);

        step.Add(zebra);
        step.Add(giraf);
        step.Add(wild);




        return zoooo;
    }
}
