namespace _9Exam;

public class Player
{
    public string Name;
    public int Health;
    public int Damage;
    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    public void Attack(Player target)
    {
        Console.WriteLine($"{Name} attacked {target.Name} for {Damage} damage!");
        target.Health -= Damage;
    }
    public void Heal(Player target)
    {
        int healRate = 30;
        target.Health += healRate;
        Console.WriteLine($"{Name} healed for {healRate} hp!");
    }
}