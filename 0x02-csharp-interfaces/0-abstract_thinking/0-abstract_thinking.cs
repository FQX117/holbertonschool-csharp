using System;

abstract class Base
{
    /// <summary>
    /// base class
    /// </summary>
    public string name = "";
    public override ToString()
    {
    return String.Format("{0} is a {1}", name, this.GetType().Name);
    }
}
