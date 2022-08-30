using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 99; i++)
        {
            Console.WriteLine("{0} = 0x{1:x}", i, i);
        }
    }
}
