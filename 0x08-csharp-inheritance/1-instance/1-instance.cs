using System;
using System.Collections.Generic;

///<summary>Class for object testing</summary>
class Obj
{
    ///<summary>check if its inherited</summary>
	///<returns>True or false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsInstanceOfType(obj);
    }
}
