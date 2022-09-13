using System;
using System.Collections.Generic;

///<summary>Class for object testing</summary>
class Obj
{
    ///<summary>check if its a subclass</summary>
	///<returns>True or false</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassof(baseType);
    }
}
