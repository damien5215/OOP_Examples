using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringReverse
    {
        // Reverses the characters in a string
        public static void reverse() 
        {
            //string input = "abcd";
            string input = "Hello, how are you?";
            string result = "";

            Console.WriteLine("\n" + input);

            for (int i = (input.Length - 1); i >= 0; i--) 
            {
                result += input[i];
            }

            Console.WriteLine("\n" + result + "\n");
        }
    }
}
