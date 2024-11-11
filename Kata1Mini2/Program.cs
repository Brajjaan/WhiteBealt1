namespace Kata1Mini2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Bryan";
        int health = 100;
        float power = 15.5f;
        float experience = 250.7f;
        string gold = "150,3333333";
        bool isParalyzed = true;

        Double healthToDouble = health;
        int powerAsInt = (int)power;
        Double experienceAsInt = (int)experience;
        Convert.ToDouble(gold);

    
        
        Console.WriteLine(healthToDouble);
        Console.WriteLine(powerAsInt);
        Console.WriteLine(experienceAsInt);
        Console.WriteLine(gold);
    }
}