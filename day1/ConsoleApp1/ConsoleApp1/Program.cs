class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int generatedNumber = random.Next(1, 11);
        int numberOfAttempts = 0;
        int maxAttempts = 3;
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine($"You have {maxAttempts} attempts to guess the number between 1 and 10.");

        while (numberOfAttempts < maxAttempts)
        {
            Console.Write("Enter your guess: ");
            if (int.TryParse(Console.ReadLine(), out int userGuess))
            {
                if (userGuess == generatedNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number: {generatedNumber}");
                    hasGuessedCorrectly = true;
                    break;
                }
                else if (numberOfAttempts < (maxAttempts - 1))
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            numberOfAttempts++;
        }

        if (!hasGuessedCorrectly)
        {
            Console.WriteLine("Sorry, you've used all your attempts.");
        }
        Console.ReadKey();
    }
}



