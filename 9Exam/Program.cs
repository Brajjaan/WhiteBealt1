namespace _9Exam;

class Program
{
    static void Main(string[] args)
    {
        bool gameActive = true;
        bool playerTurn = true;
        Player hero = new Player("Hero", 50, 15);
        Player enemy = new Player("Enemy", 50, 15);

        while (gameActive)
        {
            Console.WriteLine("Choose an action!\n" +
                              "1. Attack\n" +
                              "2. Heal");
            int action = int.Parse(Console.ReadLine());
            
            if (action == 1)
            {
                hero.Attack(enemy);
                Console.WriteLine();
            }
            else if (action == 2)
            {
                hero.Heal(hero);
                Console.WriteLine();
            }
            
            if (enemy.Health <= 0)
            {
                Console.WriteLine("Enemy defeated! You win!");
                gameActive = false;
                continue;
            }
            enemy.Attack(hero);
            Console.WriteLine();
            
            if (hero.Health <= 0)
            {
                Console.WriteLine("You lose!");
                gameActive = false;
            }
        }
        
    }
}



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

