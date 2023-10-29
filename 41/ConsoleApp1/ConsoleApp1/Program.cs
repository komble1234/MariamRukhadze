class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 123, 456, 789 };

        Console.WriteLine("Enter the index:");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            int digitSum = SumOfDigitsAtIndex(numbers, index);

            Console.WriteLine($"The sum of digits at index {index} is: {digitSum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the index.");
        }
    }

    static int SumOfDigitsAtIndex(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        int number = array[index];
        int sum = 0;

        string numberAsString = number.ToString();
        foreach (char digitChar in numberAsString)
        {
            if (int.TryParse(digitChar.ToString(), out int digit))
            {
                sum += digit;
            }
        }

        return sum;
    }
}