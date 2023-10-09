using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the first array (N): ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        string[] firstArray = new string[N];

        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Element {i + 1}: ");
            firstArray[i] = Console.ReadLine();
        }

        Console.Write("Enter the size of the second array: ");
        if (!int.TryParse(Console.ReadLine(), out int M) || M <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        int[] secondArray = new int[M];

        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < M; i++)
        {
            Console.Write($"Element {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out secondArray[i]))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                return;
            }
        }

        
        string[] connectedArray = new string[N + M];
        int index = 0;
        int t = 0;
        int T = 0;
     
        if (N < M)
        {
            t = N;
            T = M;
        }
        else
        {
            t = M;
            T = N;
        }
        for (int i = 0; i <t; i++)
            {
                connectedArray[index] = firstArray[i];
                connectedArray[index + 1] = secondArray[i].ToString();
                index += 2;
            }
       
        if (N < M)
        {
            for (int i = 0; i < T - t; i++) {
                connectedArray[index] = secondArray[t].ToString();
                t++;
            }
        }
        else
        {
            for (int i = 0; i < T - t; i++)
            {
                connectedArray[index] = firstArray[t];
                t++;
            }
        }

        Console.WriteLine("\nConcatenated array:");
        foreach (string element in connectedArray)
        {
            Console.WriteLine(element);
        }
    }
}

