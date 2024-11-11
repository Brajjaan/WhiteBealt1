namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your name?");

        string name = Console.ReadLine();
        
        Console.WriteLine($"Hello, {name}! " +
                          $"How excited are you for this adventure");
        
        int excitetment = int.Parse(Console.ReadLine());

        if (excitetment <= 4)
        {
            Console.WriteLine("Seem a little down eh?");
        }
        else
        {
            Console.WriteLine("Fantastic lets get going!");
        }

        Console.ReadKey();
    }
}