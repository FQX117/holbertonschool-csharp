using System;

class Program
{
    static void Main(string[] args)
    {
        int flag = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int x = i + 1; x < 10; x++)
            {
                if (flag == 1)
                {
                    Console.Write(", ");
                }
                flag = 1;
                Console.Write("{0}{1}", i, x);
            }
        }
        Console.WriteLine();
    }
}
