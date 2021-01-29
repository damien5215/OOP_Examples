using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 5 };

            var result = LamdaEx.Square(numbers);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

        }
    }
}

//FibConsole.MenuFunction();

//int[] arr = { 17, 2, 34, 48, 25 };
//Bubble bubble1 = new Bubble();
//bubble1.Sort2(arr);
