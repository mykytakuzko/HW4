namespace Task4;

public class Matrix
{
    public int[,] arr { get; set; } = new int[3, 3];

    public int this[int row, int column]
    {
        get => arr[row, column];
        set => arr[row, column] = value;
    }

    public Matrix()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = random.Next(0, 10);
            }
        }
    }

    public override string ToString()
    {
        string result = "";
        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result += $"{arr[i, j]}   ";
            }

            result += "\n";
        }

        return result;
    }

    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
        Matrix result = new Matrix();

        for (int i = 0; i < result.arr.GetLength(0); i++)
        {
            for (int j = 0; j < result.arr.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
    
    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        Matrix result = new Matrix();

        for (int i = 0; i < result.arr.GetLength(0); i++)
        {
            for (int j = 0; j < result.arr.GetLength(1); j++)
            {
                if (matrix1[i, j] < matrix2[i, j])
                {
                    throw new Exception($"Element [{i}, {j}] of the first array less than this element of the second array");
                }
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        Matrix result = new Matrix();

        for (int i = 0; i < result.arr.GetLength(0); i++)
        {
            for (int j = 0; j < result.arr.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }

        return result;
    }
    
    public static Matrix operator *(Matrix matrix1, int number)
    {
        Matrix result = new Matrix();

        for (int i = 0; i < result.arr.GetLength(0); i++)
        {
            for (int j = 0; j < result.arr.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] * number;
            }
        }

        return result;
    }

    public static bool operator ==(Matrix matrix1, Matrix matrix2)
    {
        return matrix1.ToString().Equals(matrix2.ToString());
    }
    
    public static bool operator !=(Matrix matrix1, Matrix matrix2)
    {
        return !matrix1.ToString().Equals(matrix2.ToString());
    }
}