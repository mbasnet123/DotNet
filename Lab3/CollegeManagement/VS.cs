using System;
namespace Lab3.College;

class VS{
    private int noOfStudent = 4;
    private String [] faculty = ["BCA", "BBM", "BBS"];

    public int getNoOfStudent(){
        return noOfStudent;
    }

    public void setNoOfStudent(int noOfStudent){
        this.noOfStudent = noOfStudent;
    }

    public String[] getFaculty(){
        return faculty;
    }

    public void setFaculty(String[] faculty){
        this.faculty = faculty;
    }

    public void Admission(){
        Console.WriteLine("Enter no of student to add:");
        int newNoOfStudent = Convert.ToInt32(Console.ReadLine());
        newNoOfStudent+= noOfStudent;
        Console.WriteLine($"total no of student = {newNoOfStudent}");
    }

    public void Resticate(){
        Console.WriteLine("Enter no of student to resticate:");
        int newNoOfStudent = Convert.ToInt32(Console.ReadLine());
        newNoOfStudent = noOfStudent - newNoOfStudent;
        Console.WriteLine($"total no of student = {newNoOfStudent}");
    }

     public void AddFaculty()
    {
        Console.WriteLine("Enter the new faculty name:");
        string? newFaculty = Console.ReadLine();

        string[] newFacultyArray = new string[faculty.Length + 1];
        faculty.CopyTo(newFacultyArray, 0);
        newFacultyArray[newFacultyArray.Length - 1] = newFaculty;
        faculty = newFacultyArray;

        Console.WriteLine($"Faculty '{newFaculty}' added successfully!");
    }





    
}