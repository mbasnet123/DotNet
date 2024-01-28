class Grading{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter score(upto 100):");
        double score = Convert.ToDouble(Console.ReadLine());

        char grade = ObtainedGrade(score);
        Console.WriteLine($"The grade is {grade}");
    }
    static char ObtainedGrade(double score){
        if(score >=90 && score <=100){
            return 'A';
        } else if(score >=80 && score <90){
            return 'B';
        } else if(score >=60 && score <80){
            return 'C';
        } else if(score >=40 && score <60){
            return 'D';
        } else
            return 'E';

    }
}