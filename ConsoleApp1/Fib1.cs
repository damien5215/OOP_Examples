﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// n = 46, result = 1836311903 and n = 47, result = 2971215073
// Signed 32-bit integer, largest positive number is 2,147,483,647
// Changed fibArray[] to contain "double" therefore can compute fib numbers > n = 46 

namespace ConsoleApp1
{
    public class Fib1
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
                return 1;  // return n
            }
            else if (fibArray[n] != 0)
            {
                return fibArray[n];
            }
            else
            {
                fibArray[n] = calcFib(n - 1, fibArray) + calcFib(n - 2, fibArray);
                return fibArray[n];
            }
        }
    }
}

//int n1 = 46;

//Console.WriteLine("");
//Console.WriteLine("The " + n1 + "th term of the fibonacci sequence is: " + Fib1.Fib(n1));
//Console.WriteLine("");
