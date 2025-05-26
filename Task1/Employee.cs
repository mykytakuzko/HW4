namespace Task1;

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name} has {Salary} salary";
    }

    public static Employee operator +(Employee employee, int salary)
    {
        return new Employee(employee.Name, employee.Salary + salary);
    }
    
    public static Employee operator -(Employee employee, int salary)
    {
        if (employee.Salary < salary)
        {
            throw new Exception("Current salary less than second argument");
        }
        return new Employee(employee.Name, employee.Salary - salary);
    }

    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }
    
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Salary != employee2.Salary;
    }

    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.Salary > employee2.Salary;
    }
    
    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.Salary < employee2.Salary;
    }
}