using System;

class Program
{
    static void Main(string[] args)
    {
        string space = ", ";
        for (int i = 0; i < 100; i++)
        {
            Console.Write("{0:D2}", i);
            if (i == 99)
            {
                space = "\n";
            }
                Console.Write(space);
        }
    }
}
