using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // This method used to see every step of calculation
    class Fib2
    {
        public static double Fib(int n)
        {
            Console.WriteLine();
            if (n < 2)
            {
                return n;
            }
            else
            {
                n++;
                double[] fibArray = new double[n];
                fibArray[0] = 0;
                fibArray[1] = 1;
                n--;

                Console.Write("array = ");

                for (int i = 0; i < fibArray.Length; i++)
                {
                    Console.Write(fibArray[i] + " ");
                }
                Console.WriteLine("\n");

                return calcFib(n, fibArray);
            }
        }

        static double calcFib(int n, double[] fibArray)
        {
            if (n < 2)
            {
                Console.Write("n = " + n + ", A:   ");

                for (int i = 0; i < fibArray.Length; i++) 
                {
                    Console.Write(fibArray[i] + " ");
                }
                Console.WriteLine("");

                return n;
            }
            else if (fibArray[n] != 0)
            {
                Console.Write("n = " + n + ", B:   ");
                for (int i = 0; i < fibArray.Length; i++)
                {
                    Console.Write(fibArray[i] + " ");
                }
                Console.WriteLine("");

                return fibArray[n];
            }
            else
            {
                fibArray[n] = calcFib(n - 1, fibArray) + calcFib(n - 2, fibArray);
                Console.Write("n = " + n + ", C:   ");
                for (int i = 0; i < fibArray.Length; i++)
                {
                    Console.Write(fibArray[i] + " ");
                }
                Console.WriteLine("");

                return fibArray[n];
            }
        }
    }
}
