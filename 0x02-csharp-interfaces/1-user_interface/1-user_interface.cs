using System;

abstract class Base
{
    /// <summary>
    /// base class
    /// </summary>
    public string name = "";
    public override string ToString()
    {
    return (this.name + " is a " + this.GetType().ToString());
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
/// <summary>
/// test class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public bool isCollected { get; set; }
    public int durability { get; set; }

    public void Break()
    {

    }
    public void Interact()
    {

    }
    public void Collect()
    {

    }
    public string name = "";
    public override string ToString()
    {
    return (this.name + " is a " + this.GetType().ToString());
    }
}
