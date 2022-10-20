using System;
public class OOP
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.student_id = Convert.ToInt32(Console.ReadLine());
        s1.student_name = Console.ReadLine();
        s1.d_o_b = Console.ReadLine();
        s1.display();
    }
}
class Student
{
    public int student_id;
    public string student_name;
    public string d_o_b;

    
    public void display()
    {
        Console.WriteLine("Student ID: " + student_id + "\nStudent Name: "+ student_name+"\nStudent Date of birth: "+ d_o_b);
    }
}