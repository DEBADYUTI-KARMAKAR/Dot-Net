using System;
//
class containing_I
{
    int i = 50;

    public virtual void printNum()
    {
        Console.WriteLine("This is class of i " + i);
    }
}

class containing_J : containing_I
{
    int j = 56;

    public override void printNum()
    {
        Console.WriteLine("This is class of j " + j);
    }
}
class Questin4
{
    static void Main()
    {
        containing_I c1 = new containing_J();
        c1.printNum();
    }
}