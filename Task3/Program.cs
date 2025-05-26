namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        CreditCard creditCard1 = new CreditCard("Mono", 10000);
        CreditCard creditCard2 = new CreditCard("Privat", 5000);
        
        Console.WriteLine(creditCard1 + 5000);
        Console.WriteLine(creditCard1 - 5000);
        Console.WriteLine(creditCard1 == creditCard2);
        Console.WriteLine(creditCard1 != creditCard2);
        Console.WriteLine(creditCard1 > creditCard2);
        Console.WriteLine(creditCard1 < creditCard2);
    }
}