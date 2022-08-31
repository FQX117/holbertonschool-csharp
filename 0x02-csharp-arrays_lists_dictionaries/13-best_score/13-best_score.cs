using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = 0;
        string name = "None";
        foreach (KeyValuePair<string, int> val in myList)
        {
            if (val.Value > max)
            {
                max = val.Value;
                name = val.Key;
            }
        }
        return name;
    }
}
