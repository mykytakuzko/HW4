namespace Task3;

public class CreditCard
{
    public string Name { get; set; }
    public int Balance { get; set; }

    public CreditCard(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }

    public override string ToString()
    {
        return $"{Name} has {Balance} money";
    }

    public static CreditCard operator +(CreditCard creditCard, int units)
    {
        return new CreditCard(creditCard.Name, creditCard.Balance + units);
    }
    
    public static CreditCard operator -(CreditCard creditCard, int units)
    {
        if (creditCard.Balance < units)
        {
            throw new Exception("Current balance less than second argument");
        }
        return new CreditCard(creditCard.Name, creditCard.Balance - units);
    }

    public static bool operator ==(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.Balance == creditCard2.Balance;
    }
    
    public static bool operator !=(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.Balance != creditCard2.Balance;
    }
    
    public static bool operator >(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.Balance > creditCard2.Balance;
    }
    
    public static bool operator <(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.Balance < creditCard2.Balance;
    }
}