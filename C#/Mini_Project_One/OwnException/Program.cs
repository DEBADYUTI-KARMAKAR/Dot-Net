using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 18)
                {
                    throw new MyException("You are not elegible");
                }
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }

           



        }
    }


   public class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string msg)
            : base(msg)
        {
        }

        
    }
}
