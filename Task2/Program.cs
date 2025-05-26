namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        City city1 = new City("Kyiv", 3600000);
        City city2 = new City("Lviv", 700000);
        
        Console.WriteLine(city1 + 100000);
        Console.WriteLine(city2 - 100000);
        Console.WriteLine(city1 == city2);
        Console.WriteLine(city1 != city2);
        Console.WriteLine(city1 > city2);
        Console.WriteLine(city1 < city2);
    }
}