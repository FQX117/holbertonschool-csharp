using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> mul2 = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                mul2.Add(true);
            }
            else
            {
                mul2.Add(false);
            }
        }
        return mul2;
    }
}
