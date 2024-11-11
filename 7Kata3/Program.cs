namespace _7Kata3;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int playerLuck = rnd.Next(1, 11);
        
        Console.WriteLine($"You find a mysterious chest! \nWhat will you do?");
        
        if (Console.ReadLine() == "open")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("Success!");
            }
            else if (playerLuck >= 5)
            {
                Console.WriteLine("Minor success!");
            }
            else
            {
                Console.WriteLine("Failure!");
            }
        }
        else
        {
            Console.WriteLine("You ignore the chest...");
        }
    }
}