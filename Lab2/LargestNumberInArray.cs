using System;
namespace Lab2.Array;

class LargestNumberInArray
{
    static void Main()
    {
        // Sample array
        int[] numbers = { 12, 45, 67, 23, 89, 34, 56 };

        // Initializing maxNumber with the first element of the array
        int maxNumber = numbers[0];

        // Iterating through the array to find the largest number
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            { 
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine("The largest number in the array is: " + maxNumber);
    }
}
