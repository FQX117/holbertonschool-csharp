using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> shared = new List<int>();
        HashSet<int> different = new HashSet<int>(list2);
        foreach (int num in list1)
        {
            different.Add(num);
            if (list2.Contains(num))
            {
                shared.Add(num);
            }
        }
        foreach (int num in shared)
        {
            different.Remove(num);
        }
        List<int> difList = new List<int>(different);
        difList.Sort();
        return difList;
    }
}
