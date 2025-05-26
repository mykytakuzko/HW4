namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix();
        Console.WriteLine(matrix);
        Matrix matrix2 = new Matrix();
        Console.WriteLine(matrix2);
        
        Console.WriteLine(matrix + matrix2);
        try
        {
            Console.WriteLine(matrix - matrix2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(matrix * matrix2);
        Console.WriteLine(matrix * 2);
        Console.WriteLine(matrix == matrix2);
        Console.WriteLine(matrix != matrix2);
    }
}