namespace Basic3;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10] {1,2,3,4,0,6,7,8,9,10};
        array = [11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
       // array[1] = 2;
        //Console.WriteLine(array[0]);
        //Console.WriteLine(array[1]);
        //Console.WriteLine(array[2]);

        Console.WriteLine("=========");
        for (int i = 0; i < array.Length; i++)
        {
            int tmp = array[i];
            Console.WriteLine(tmp);
        }
        Console.WriteLine("================");
        foreach (int tmp in array)
        {
            Console.WriteLine(tmp);
        }

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        matrix[0, 1] = 2;


        int[,,] kubus = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

        foreach (int z in kubus)
        {
            Console.WriteLine(z);
        }
        Console.WriteLine("+++++++++++++++");


        for (int x = 0; x < kubus.GetLength(0); x++)
        {
            for(int y = 0; y < kubus.GetLength(1); y++)
            {
                for (int z = 0;z < kubus.GetLength(2); z++)
                {
                    int tmp = kubus[x,y,z];
                    Console.WriteLine(tmp);
                }
            }
        }
    }
}
