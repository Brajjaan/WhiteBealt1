namespace Kata1Mini;

class Program
{
    static void Main(string[] args)
    {
        string name = "Bryan";
        int health = 100;
        float attackPower  = 15.5f;
        bool isParalyzed = false;
        double GoldCoins = 24.75;
        
        Console.WriteLine($"Name: {name}\n" +
                          $"Health: {health} \n" +
                          $"Attack Power: {attackPower}\n" +
                          $"Is paralyzed: {isParalyzed}\n" +
                          $"Gold Coins: {GoldCoins}");
    }
}