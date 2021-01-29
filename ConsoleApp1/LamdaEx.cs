using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LamdaEx
    {
        public static IEnumerable<int> Square(int[] input) 
        {
            var squaredNumbers = input.Select(x => x * x);

            return squaredNumbers;
        } 

    }
}

//int[] numbers = { 2, 3, 4, 5 };

//var result = LamdaEx.Square(numbers);

//foreach (int number in result) 
//{
//    Console.WriteLine(number);
//}
