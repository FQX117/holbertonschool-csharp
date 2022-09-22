using System;

abstract class Base
{
    /// <summary>
    /// base class
    /// </summary>
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
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
}
