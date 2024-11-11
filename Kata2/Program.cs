namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        Attributes attr = new Attributes();
        attr.Print();
    }
}

public class Attributes
{
   public String name = "Lira";
   public int level = 5;
   public float health = 75.5f;
   public double experience = 1025.75;
   public bool hasMagic = true;
   public char rank = Convert.ToChar("A");
   public double experienceCap = 1200;
   public double remainingExperience => experienceCap - experience;

   public void Print()
   {
       Console.WriteLine($"Name: {name}");
       Console.WriteLine($"Level: {level}");
       Console.WriteLine($"Health: {health}");
       Console.WriteLine($"Experience: {experience}");
       Console.WriteLine($"Has Magic: {hasMagic}");
       Console.WriteLine($"Rank: {rank}");
       Console.WriteLine($"Remaining Experience: {remainingExperience}");
   }
}