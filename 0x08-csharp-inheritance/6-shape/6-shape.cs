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

/// <summary>rectangle</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    //width of rectangle
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
        if (value < 0)
        {
            throw new ArgumentException("Width must be greater than or equal to 0");
        }
        width = value;
        }
    }
    //Height of rectangle
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
        if (value < 0)
        {
            throw new ArgumentException("Height must be greater than or equal to 0");
        }
        height = value;
        }
    }
}
