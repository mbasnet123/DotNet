using System;

namespace Lab2.Integer
{
    class PositiveInteger
    {
        static void Main(string[] args)
        {
            int userInput;

            do
            {
                Console.Write("Enter a positive integer: ");

                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput <= 0)
                {
                    Console.WriteLine("It's not a positive integer. Please try again.");
                    continue;
                }
            } while (userInput <= 0);  // <-- Corrected condition

            Console.WriteLine("You entered the positive integer: {0}", userInput);
        }
    }
}
