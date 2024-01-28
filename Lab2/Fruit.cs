using System;
namespace Lab2.FruitArray;
class Fruit{
    static void Main(string[] args)
    {
        string[] arr = ["Apple","Banana","Orange","Grape","Mango"];
        foreach(string fruit in arr){
            Console.WriteLine(fruit);
        }
    }
}