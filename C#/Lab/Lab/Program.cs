using System;
public class OOP
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("Student ID");
        s1.studentId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Student Name");
        s1.studentName = Console.ReadLine();
        Console.WriteLine("DOB");
        s1.DOB = Console.ReadLine();
        s1.Display();
    }
}
class Student
{
    public int studentId;
    public string studentName;
    public string DOB;


    public void Display()
    {
        Console.WriteLine("Student ID: " + studentId + "\nStudent Name: " + studentName + "\nStudent Date of birth: " + DOB);
    }
}