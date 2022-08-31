using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keyList = new List<string>();
        foreach (KeyValuePair<string, string> entry in myDict)
        {
            keyList.Add(entry.Key);
        }
        keyList.Sort();
        foreach(string val in keyList)
        {
            Console.WriteLine("{0}: {1}", val, myDict[val]);
        }
    }
}
