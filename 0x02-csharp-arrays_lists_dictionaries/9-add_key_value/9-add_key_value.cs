using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        myDict.Remove(key);
        myDict.Add(key, value);
        return myDict;
    }
}
