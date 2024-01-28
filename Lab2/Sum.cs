using System;
namespace Lab2.SumNum;

class Sum{
    static void Main(string[] args)
    {
        int i;
        int sum = 0;
        for(i=0;i<=100;i++){
            sum += i;
        }
        Console.WriteLine(sum);
    }
}