using System;

class NullableTypes6{
    static void Main(string[] args)
    {
        bool ?isGraduated = true;

        if (isGraduated.Value)
        {
            Console.WriteLine("User is Graduated");
        } else if (!isGraduated.Value)
        {
            Console.WriteLine("User is not graduated");
        } else
        {
            Console.WriteLine("User has not checked yet");
        }
    }
}