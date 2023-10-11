class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array in ascending order:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

}

