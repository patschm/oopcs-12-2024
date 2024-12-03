
namespace Tekenen;

class Canvas
{
    private Figuur[] figuren = new Figuur[100];

    public void Add(Figuur fig)
    {
        for(int i = 0;  i < figuren.Length; i++)
        {
            if (figuren[i] == null)
            {
                figuren[i] = fig;
                return;
            }
        }
    }

    public void Refresh()
    {
        foreach(Figuur fig in figuren)
        {
            fig?.Teken();
        }
    }
}
