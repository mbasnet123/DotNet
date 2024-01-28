using System;

namespace Lab2.Guess;

class GuessingGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11);

        int userGuess;

        while (true)
        {
            Console.WriteLine("Enter a number between 1 and 10");

            try
            {
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input");
                continue;
            }

            if (userGuess < 1 || userGuess > 10)
            {
                Console.WriteLine("Number is between 1 and 10. Try again");
            }



            else if (userGuess == secretNumber)
            {
                Console.WriteLine("You have guessed right.");
                break;
            }

            else if (userGuess < secretNumber)
            {
                Console.WriteLine("Too low! Guess higher.");
            }
            else
            {
                Console.WriteLine("Too high! Guess lower.");
            }

        }

    }
}

