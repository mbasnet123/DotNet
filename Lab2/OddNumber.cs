using System;
namespace Lab2.Odd;

class OddNumber
{
    static void Main()
    {
        Console.WriteLine("Printing odd numbers from 1 to 10 excluding 5:");

        for (int i = 1; i <= 10; i++)
        {
            // Skip number 5 using continue
            if (i == 5)
                continue;

            // Print odd numbers
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
