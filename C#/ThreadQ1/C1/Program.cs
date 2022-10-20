using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread thr = new Thread(Newthread);
            thr.Start();
            Console.WriteLine("MainThread Ends!!");
        }

        static void Newthread()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Mango");
                Thread.Sleep(1000);
            }
            Console.WriteLine("NewThread End...");
        }
    }
}
