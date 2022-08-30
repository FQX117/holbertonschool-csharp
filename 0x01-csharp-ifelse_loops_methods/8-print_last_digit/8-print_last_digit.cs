using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        Console.Write("{0}", Math.Abs(number % 10));
        return Math.Abs(number % 10);
    }
}
