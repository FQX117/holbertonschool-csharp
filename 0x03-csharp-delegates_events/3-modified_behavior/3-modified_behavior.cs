using System.Reflection.Metadata.Ecma335;
using System;


 // holds values 
public enum Modifier
{
    Weak, Base, Strong
}
public delegate float CalculateModifier(float baseValue, Modifier modifier);


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


    public delegate int CalculateHealth(float damage);
    //Dmg
    public void TakeDamage(float damage)
    {
        float HPchange;
        if (damage < 0)
        {
            Console.Writeline("{0} takes 0 damage!", name);
         }
        else
        {
            HPchange = hp - damage;
            Console.Writeline("{0} takes {1} damage!", name, damage);
       }
        ValidateHP(HPchange);

    }
    //heal
    public void HealDamage(float heal)
    {
        float HPchange;
        if (heal < 0)
        {
            Console.Writeline("{0} heals 0 HP!", name);
        }
        else
        {
            HPchange = hp + heal;
            Console.Writeline("{0} heals {1} HP!", name, heal);

 }
        ValidateHP(HPchange);
    }
    // sets new HP
    public void ValidateHP(float newHp)
    {
        if (newHP < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier = Modifier.weak)
        {
            return baseValue / 2;
        }
        else if (modifier = Modifier.base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5;
        }
    }
}
