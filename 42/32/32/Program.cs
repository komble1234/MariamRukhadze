

class Program
{
    static void Main(string[] args)
    {
        char[] userArray = GetUserInputArray();
        char symbolToFind = GetSymbolToFind();

        int symbolCount = CountSymbolOccurrences(userArray, symbolToFind);
        PrintResult(symbolToFind, symbolCount);
    }

    static char[] GetUserInputArray()
    {
        Console.Write("Enter the size of the array: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
            Environment.Exit(1);
        }

        char[] array = new char[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            string input = Console.ReadLine();

            if (input.Length != 1)
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
                Environment.Exit(1);
            }

            array[i] = input[0];
        }

        return array;
    }

    static char GetSymbolToFind()
    {
        Console.Write("Enter the symbol to find: ");
        string input = Console.ReadLine();

        if (input.Length != 1)
        {
            Console.WriteLine("Invalid input. Please enter a single character as the symbol to find.");
            Environment.Exit(1);
        }

        return input[0];
    }

    static int CountSymbolOccurrences(char[] array, char symbol)
    {
        int count = 0;

        foreach (char element in array)
        {
            if (element == symbol)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(char symbol, int count)
    {
        Console.WriteLine("Symbol '{symbol}' was found {count} times.");
    }
}
