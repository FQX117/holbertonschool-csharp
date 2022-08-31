using System;
using System.Collections.Generic;

class List
{
    public static void DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count - 1 || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return;
        }
        int count = 0;
        foreach (int val in myList)
        {
            if (count == index)
            {
                myList.Remove(val);
                break;
            }
            count++;
        }
        return;
    }
}
