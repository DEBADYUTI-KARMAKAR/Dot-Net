using System;
using System.Xml.Linq;

class Student
{
    public String name;
    public int stuAge;
    public int engScore;
    public int mathScore;
    public int scienceScore;
    public int Total = 0;
    public float Avg;

    public void calculateAvarage()
    {
        Total = (engScore + mathScore + scienceScore);
    }
    public void calculatePercentage()
    {
        Avg = Total / 3;
    }
    public void showData()
    {
        Console.WriteLine("Name of the student: " + name + "\n" +
        "Age of student: " + stuAge + "\n" +
        "Total " + Total + "\n" +
        "Percentage " + Avg);
    }

}

class Question2
{
    static void Main()
    {
        Student s1 = new Student();
        
            Console.WriteLine("Enter your name : ");
            s1.name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            s1.stuAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your English score : ");
            s1.engScore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Math Score : ");
            s1.mathScore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Sciencce Score : ");
            s1.scienceScore = Convert.ToInt32(Console.ReadLine());

        
        s1.calculateAvarage();
        s1.calculatePercentage();
        s1.showData();

    }
}