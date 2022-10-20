using System;
class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello EveryOne");
        Console.Write("Hello C# \n");
        int a = 10;
        int b = 20;
        int c = a + b;
        Console.WriteLine(c);
        Console.WriteLine("Hello" + c);
        for(int i= 1; i < 6; i++)
        {
            if (i % 2 == 0)
            {

            Console.WriteLine(i +"is even");
            }
            else
            {
                Console.WriteLine(i + "is Odd");
            }
        }

        Console.WriteLine("---------------------");
        int k = 1;
        while (k < 10)
        {
            Console.WriteLine(k);
            k++;
        }
        Console.WriteLine("---------------------");
        int n = 1;
        do
        {
            Console.WriteLine(n);
            n++;
        } while (n <= 5);
    }
}