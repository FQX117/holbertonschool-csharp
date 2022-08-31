using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> hs = new HashSet<int>(myList);
        foreach (int num in hs)
        {
            sum += num;
        }
        return sum;
    }
}
