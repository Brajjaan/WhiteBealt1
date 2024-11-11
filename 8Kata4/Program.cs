namespace _8Kata4;

class Program
{
    static void Main(string[] args)
    {
        for (int w = 1; w <= 2; w++)
        {
            Console.WriteLine($"Wave {w} is starting!");
            
            for (int i = 1; i <= 4; i++) {
                Console.WriteLine($"Enemy #{i} has spawned");
            } 
            Console.WriteLine($"\nWave {w} completed! Preparing next wave...\n");
            Thread.Sleep(1000);
        }
        Console.WriteLine("All waves completed!");
    }
}