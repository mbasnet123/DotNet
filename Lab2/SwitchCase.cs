class SwitchCase{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter day of week:");
        string? dayOfWeek = Console.ReadLine();

        switch(dayOfWeek){
            case "Saturday":
            case "Sunday":
                Console.WriteLine("Weekend");
                break;
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                Console.WriteLine("Weekday");
                break;
            default:
                Console.WriteLine("Unvalid day");
                break;

        }
    }
}