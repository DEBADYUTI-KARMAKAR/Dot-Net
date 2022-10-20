using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Thread t1 = new Thread(PrintWord.PrintM);
            t1.Start();
            Thread t2 = new Thread(PrintWord.PrintH);
            t2.Start();
            Thread t3 = new Thread(PrintWord.PrintW);
            t3.Start();

        }
    }
    class PrintWord
    {
        static public void PrintM()
        {

            while (true)
            {
                Console.WriteLine("Good morning");
                
                Thread.Sleep(2000);
            }

        }
        static public void PrintH()
        {

            while (true)
            {
               
                Console.WriteLine("Hello");
                
            }
                Thread.Sleep(3000);
        }
        static public void PrintW()
        {

            while (true)
            {
                
                Console.WriteLine("Welcome");
            }
                Thread.Sleep(1000);
        }
    }
}
