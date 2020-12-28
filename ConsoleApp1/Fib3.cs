using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fib3
    {
        public static double Fib(int n)
        {
            double fib1 = 0;
            double fib2 = 1;
            double newfib1 = 0;
            double newfib2 = 0;

            for (int i = 0; i < n; i++)
            {
                newfib2 = fib2 + fib1;
                newfib1 = fib2;

                Console.Write(fib1 + " ");

                fib1 = newfib1;
                fib2 = newfib2;
            }

            Console.Write(fib1 + " ");
            return fib1;
        }
    }
}
