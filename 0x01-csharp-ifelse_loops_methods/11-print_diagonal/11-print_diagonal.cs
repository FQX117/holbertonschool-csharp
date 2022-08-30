using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
        else
        Console.WriteLine();
    }
}
