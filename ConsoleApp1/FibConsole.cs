﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FibConsole
    {
        static void FibNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int fibInputNumber = Convert.ToInt32(Console.ReadLine());
            float[] fib = new float[fibInputNumber];

            fib[0] = fib[1] = 1;

            for (int i = 2; i < fibInputNumber; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            float result = fib[fibInputNumber - 1];

            Console.WriteLine("fib(" + fibInputNumber + ") = " + result + "\n\n");
        }

        static void FibNumbers2()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int fibInputNo = Convert.ToInt32(Console.ReadLine());
            double result = Fib1.Fib(fibInputNo);
            Console.WriteLine("fib(" + fibInputNo + ") = " + result + "\n\n");
        }

        public static void MenuFunction()
        {
            Console.WriteLine("Console FibCalculator in C#\r");
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Enter 2 - Fibonacci Calculator 2\r");
            Console.WriteLine("Enter 1 - Fibonacci Calculator 1\r");
            Console.WriteLine("Enter 0 - Exit Console App\n");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                case 1:
                    FibNumbers();
                    MenuFunction();
                    break;
                case 2:
                    FibNumbers2();
                    MenuFunction();
                    //Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

//FibConsole.MenuFunction();
