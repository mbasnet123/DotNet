using System;

class StringTypes4{
    static void Main(string[] args)
    {
        String abc = "Manish\nSunil\nAasis";
        Console.WriteLine(abc);

        //verbatim literal
        // with the use of verbatim literal, escape character is treated as normal character
        String path1 = "C:Desktop\\Project\\File1";
        String path = @"C:Desktop\Work\Project1";
        Console.WriteLine(path1);
        Console.WriteLine(path);
    }
}