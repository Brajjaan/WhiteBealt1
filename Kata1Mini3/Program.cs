namespace Kata1Mini3;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int playerLuck = random.Next(1,11);
        
        Console.WriteLine($"Would you like to attack?");
        string input = Console.ReadLine();

        if (input == "y")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("Attack succeeded!");
            }
            else if (playerLuck == 7)
            {
                Console.WriteLine("Attack barely succeeded!");
            }
            else
            {
                Console.WriteLine("Attack missed");
            }
        }

        if (input == "n")
        {
            Console.WriteLine($"Retreated");
        }
    }
}