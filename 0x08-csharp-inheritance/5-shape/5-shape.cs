using System;

/// <summary>Base Class</summary>
class Shape
{
    /// <summary>error msg</summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
    
}
