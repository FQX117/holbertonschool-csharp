using System;
using System.Collections.Generic;
using System.Reflections;

///<summary>Class for object testing</summary>
class Obj
{
    ///<summary>prints everything</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo propInfo in t.GetProperties())
        {
            Console.WriteLine(propInfo.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo metInfo in t.GetMethods())
        {
            Console.WriteLine(metInfo.Name);
        }
    }
}
