using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExceptionEx
    {
        // Examples adapted from w3schools.com
        public static void idea1() 
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }

        public static void checkAge()
        {
            int age = 31;

            if (age < 21)
            {
                throw new ArithmeticException("Access denied - You must be at least 21 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

    }
}
