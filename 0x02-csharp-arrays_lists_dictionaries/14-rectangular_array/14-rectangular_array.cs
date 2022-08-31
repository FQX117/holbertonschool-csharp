using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] twoD = new int[5, 5];
        twoD[2,2] = 1;
        for (int i = 0; i < twoD.GetLength(0); i++)
        {
            for (int j = 0; j < twoD.GetLength(1); j++)
            {
                Console.Write(twoD[i, j]);
                if (j != twoD.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
