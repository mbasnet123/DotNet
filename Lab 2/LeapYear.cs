class LeapYear{
    static void Main(string[] args){
        Console.WriteLine("Enter no of days: ");
        int noOfDays = Convert.ToInt32(Console.ReadLine());
        if(noOfDays % 366 == 0){
            Console.WriteLine("It's a leap year");
        } else if(noOfDays < 365 || noOfDays > 366){
            Console.WriteLine("Year can't days less than 365 and more than 366");
        } else
        Console.WriteLine("It's not a leap year");
    }
}