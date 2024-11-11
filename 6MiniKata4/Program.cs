namespace _6MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }
        Console.WriteLine("\n");
        
        int count = 1;
        while (count <= 3)
        {
            Console.WriteLine($"Enemy #{count} spawned!");
            count++;
        }
    }
}