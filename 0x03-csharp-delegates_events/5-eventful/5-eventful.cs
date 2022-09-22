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
        private string status;
        

        public Player(string name = "Player", float maxHp = 100f)
        {
            if (maxHp < 1)
            {
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
                this.status = $"{name} is ready to go!";
                this.HPCheck = this.CheckStatus;
                this.maxHp = maxHp;
                this.hp = maxHp;
                this.name = name;
            }
        }
        public void PrintHealth()
        {
            Console.WriteLine("{0} has {1} / {3} health", name, hp, maxHp);
        }


    public delegate int CalculateHealth(float damage);
    //Dmg
    public void TakeDamage(float damage)
    {
        float HPchange;
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", name);
         }
        else
        {
            HPchange = hp - damage;
            Console.WriteLine("{0} takes {1} damage!", name, damage);
       }
        ValidateHP(HPchange);

    }
    //heal
    public void HealDamage(float heal)
    {
        float HPchange;
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", name);
        }
        else
        {
            HPchange = hp + heal;
            Console.WriteLine("{0} heals {1} HP!", name, heal);

 }
        ValidateHP(HPchange);
    }
    // sets new HP
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
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
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }

    public event EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            System.Console.WriteLine($"{name} is in perfect health!");
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            System.Console.WriteLine($"{name} is doing well!");
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            System.Console.WriteLine($"{name} isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
            System.Console.WriteLine($"{name} needs help!");
        else if (e.currentHp == 0)
            System.Console.WriteLine($"{name} is knocked out!");
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (true)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            System.Console.WriteLine("Health is low");
        }
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }

}
/// <summary>
/// event class
/// </summary>
public class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

     public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
