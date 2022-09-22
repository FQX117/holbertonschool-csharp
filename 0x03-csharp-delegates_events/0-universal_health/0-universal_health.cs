using System;
/// <summary>
/// player class
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name = Player, float maxHp = 100f)
    {
        if (maxHp < 1)
        {
            maxHp = 100f;
            Console.Writeline("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = maxHp;
            this.hp = maxHp;
            this.name = name;
        }
    }
    public void PrintHealth()
    {
        Console.Writeline("{0} has {1} / {3} health", name, hp, health);
    }
}
