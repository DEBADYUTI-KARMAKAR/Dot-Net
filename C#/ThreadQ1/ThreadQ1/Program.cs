using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using single thread
namespace ThreadQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintWord.PrintM);
            Console.WriteLine("Start");
            t1.Start();
           
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
                Console.WriteLine("Hello");
                Thread.Sleep(3000);
                Console.WriteLine("Welcome");
                Thread.Sleep(1000);
            }
        }
       
    }
}
