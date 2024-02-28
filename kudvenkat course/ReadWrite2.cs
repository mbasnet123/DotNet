using System;

class ReadWrite2{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        String ?username = Convert.ToString(Console.ReadLine());
        Console.WriteLine($"Hello {username}");
    }
}