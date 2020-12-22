using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fib2
    {
        public static double Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                double[] fibArray = new double[n];
                fibArray[0] = 0;
                fibArray[1] = 1;
                n--;
                return calcFib(n, fibArray);
            }
        }

        public static double calcFib(int n, double[] fibArray)
        {
            if (n < 2)
            {
                Console.WriteLine("A");
                Console.WriteLine(fibArray[0] + " " + fibArray[1] + " " + fibArray[2] + " " + fibArray[3] + " " + fibArray[4] + " " + fibArray[5]);


                return 1;  // return n
            }
            else if (fibArray[n] != 0)
            {
                Console.WriteLine("B");
                Console.WriteLine(fibArray[0] + " " + fibArray[1] + " " + fibArray[2] + " " + fibArray[3] + " " + fibArray[4] + " " + fibArray[5]);
                return fibArray[n];
            }
            else
            {
                fibArray[n] = calcFib(n - 1, fibArray) + calcFib(n - 2, fibArray);
                Console.WriteLine("C");
                Console.WriteLine(fibArray[0] + " " + fibArray[1] + " " + fibArray[2] + " " + fibArray[3] + " " + fibArray[4] + " " + fibArray[5]);
                return fibArray[n];
            }
        }
    }
}
