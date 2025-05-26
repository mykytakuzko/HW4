namespace Task2;

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }

    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }

    public override string ToString()
    {
        return $"{Population} people live in {Name}";
    }

    public static City operator +(City city, int numberOfPeople)
    {
        return new City(city.Name, city.Population + numberOfPeople);
    }
    
    public static City operator -(City city, int numberOfPeople)
    {
        if (city.Population < numberOfPeople)
        {
            throw new Exception("Population of city less than second argument");
        }
        return new City(city.Name, city.Population - numberOfPeople);
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }
    
    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }
    
    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }
}