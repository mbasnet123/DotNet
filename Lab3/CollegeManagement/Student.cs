using System;
using Lab3.College;
namespace Lab3.Student;

class Student{
    static void Main(string[] args)
    {
        VS student1 = new VS();
        // student1.Admission();

         student1.AddFaculty();

        Console.WriteLine("Updated faculty list:");
        foreach (string facultyName in student1.getFaculty())
        {
            Console.WriteLine(facultyName);
        }
    }
}