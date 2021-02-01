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

        public static void numbers() 
        {
            int[] scores = new int[] { 97, 92, 81, 60, 34 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + "\n");
            }
        }
    }
}

//int[] numbers = { 2, 3, 4, 5 };

//var result = LamdaEx.Square(numbers);

//foreach (int number in result) 
//{
//    Console.WriteLine(number);
//}


//LamdaEx.numbers();
