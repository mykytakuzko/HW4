namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Ivan", 5001);
        Employee employee2 = new Employee("Sergey", 5000);
        
        Console.WriteLine(employee1 + 99);
        Console.WriteLine(employee1 - 1);
        Console.WriteLine(employee1 == employee2);
        Console.WriteLine(employee1 != employee2);
        Console.WriteLine(employee1 > employee2);
        Console.WriteLine(employee1 < employee2);
    }
}