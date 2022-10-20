using System;
public class OOP
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.StudentId = Convert.ToInt32(Console.ReadLine());
        s1.StudentName = Console.ReadLine();
        s1.DOB = Console.ReadLine();
        s1.display();
    }
}
class Student
{
    public int StudentId;
    public string StudentName;
    public string DOB;


    public void display()
    {
        Console.WriteLine("Student ID: " + StudentId + "\nStudent Name: " + StudentName + "\nStudent Date of birth: " + DOB);
    }
}