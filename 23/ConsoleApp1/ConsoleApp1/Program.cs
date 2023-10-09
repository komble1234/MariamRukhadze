using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matrix Determinant Calculator");
        Console.WriteLine("Enter the size of the matrix (2 or 3):");

        if (!int.TryParse(Console.ReadLine(), out int matrixSize) || (matrixSize != 2 && matrixSize != 3))
        {
            Console.WriteLine("Invalid input. Please enter 2 or 3.");
            return;
        }

        double[,] matrix = new double[matrixSize, matrixSize];

        Console.WriteLine("Enter the matrix elements row by row:");
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                if (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    return;
                }
            }
        }

        // Calculate determinant based on matrix size
        double determinant = CalculateDeterminant(matrix);

        // Print the matrix
        Console.WriteLine("\nEntered Matrix:");
        PrintMatrix(matrix);

        // Print the determinant
        Console.WriteLine($"\nDeterminant: {determinant}");
    }

    static double CalculateDeterminant(double[,] matrix)
    {
        int matrixSize = matrix.GetLength(0);

        if (matrixSize == 2)
        {
            // 2x2 matrix determinant calculation
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[1, 0];
            double d = matrix[1, 1];

            return a * d - b * c;
        }
        else if (matrixSize == 3)
        {
            // 3x3 matrix determinant calculation
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 0];
            double e = matrix[1, 1];
            double f = matrix[1, 2];
            double g = matrix[2, 0];
            double h = matrix[2, 1];
            double i = matrix[2, 2];

            return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
        }
        else
        {
            return 0; // Unsupported matrix size
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

