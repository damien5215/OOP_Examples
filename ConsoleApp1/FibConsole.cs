using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FibConsole
    {
        //static void FibNumbers()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Enter a number");
        //    int fibInputNumber = Convert.ToInt32(Console.ReadLine());
        //    double[] fib = new double[fibInputNumber];

        //    fib[0] = fib[1] = 1;

        //    for (int i = 2; i < fibInputNumber; i++)
        //    {
        //        fib[i] = fib[i - 1] + fib[i - 2];
        //    }
        //    double result = fib[fibInputNumber - 1];

        //    Console.WriteLine("fib(" + fibInputNumber + ") = " + result + "\n\n");
        //}

        static void FibNumbers2()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int fibInputNo = Convert.ToInt32(Console.ReadLine());
            double result = Fib1.Fib(fibInputNo);
            Console.WriteLine("\n" + "fib(" + fibInputNo + ") = " + result + "\n\n");
        }
        static void FibNumbers3()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int fibInputNo = Convert.ToInt32(Console.ReadLine());
            double result = Fib2.Fib(fibInputNo);
            Console.WriteLine("\n" + "fib(" + fibInputNo + ") = " + result + "\n\n");
        }
        static void FibNumbers4()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int fibInputNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");                        
            double result = Fib3.Fib(fibInputNo);
            Console.Write("\n");                          
            Console.WriteLine("\n" + "fib(" + fibInputNo + ") = " + result + "\n\n");
        }

        public static void MenuFunction()
        {
            Console.WriteLine("Console FibCalculator in C#\r");
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Enter 3 - Fibonacci Calculator 3 (for-loop)\r");
            Console.WriteLine("Enter 2 - Fibonacci Calculator 2 (memoization: every step)\r");
            Console.WriteLine("Enter 1 - Fibonacci Calculator 1 (memoization)\r");
            //Console.WriteLine("Enter 1 - Fibonacci Calculator 1\r");
            Console.WriteLine("Enter 0 - Exit Console App\n");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                //case 1:
                //    FibNumbers();
                //    MenuFunction();
                //    break;
                case 1:
                    FibNumbers2();
                    MenuFunction();
                    break;
                case 2:
                    FibNumbers3();
                    MenuFunction();
                    break;
                case 3:
                    FibNumbers4();
                    MenuFunction();
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
