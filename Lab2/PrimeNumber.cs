using System;
namespace Lab2.Prime;

class PrimeNumber{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 10 and 50");
        int userInput = Convert.ToInt32(Console.ReadLine());

         for (int number = userInput; number <= 50; number++)
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"The first prime number in the range is: {number}");
                break; // Exit the loop once a prime number is found
            }
        }
    }

     static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}