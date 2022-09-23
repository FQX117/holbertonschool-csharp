using System;


/// <summary>
/// add xml
/// </summary>
public enum Modifier
{
    /// <summary>
    /// player class
    /// </summary>
    Weak,
    /// <summary>
    /// player class
    /// </summary>
    Base,
    /// <summary>
    /// player class
    /// </summary>
    Strong
}
/// <summary>
/// player class
/// </summary>
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
        

        /// <summary>
        /// player class
        /// </summary>
        public Player(string name = "Player", float maxHp = 100f)
        {
            if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
        }
        /// <summary>
        /// player class
        /// </summary>
        public void PrintHealth()
        {
            Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
        }


    /// <summary>
    /// player class
    /// </summary>
    public delegate int CalculateHealth(float damage);
    /// <summary>
    /// player class
    /// </summary>
    public void TakeDamage(float damage)
     {
        if (damage < 0f)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        this.hp -= damage;
        ValidateHP(this.hp);
    }
    /// <summary>
    /// player class
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
            heal = 0f;
        }
        else
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        this.hp += heal;
        ValidateHP(this.hp);
    }
    /// <summary>
    /// player class
    /// </summary>
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
        HPCheck(this, new CurrentHPArgs(hp));
    }
    /// <summary>
    /// player class
    /// </summary>
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
    /// <summary>
    /// player class
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// player class
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            Console.WriteLine($"{name} is in perfect health!");
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            Console.WriteLine($"{name} is doing well!");
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            Console.WriteLine($"{name} isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
            Console.WriteLine($"{name} needs help!");
        else if (e.currentHp == 0)
            Console.WriteLine($"{name} is knocked out!");
    }

}
/// <summary>
/// event class
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// player class
    /// </summary>
    public readonly float currentHp;
    /// <summary>
    /// player class
    /// </summary>
     public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
