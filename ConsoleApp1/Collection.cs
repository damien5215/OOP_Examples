using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Collection
    {
        public static string[] update(string[] strArr, int index, string strReplace) 
        {
            List<string> strArrList = new List<string>(strArr);

            strArrList[index] = strReplace;

            string[] result = strArrList.ToArray();

            return result;
        }

        public static void BigSort() 
        {
            string[] unsorted = new string[] { "14", "3084193741082938", "11", "6", "2",
                                               "31415926535897932384626433832795", "1", "8" };

            List<string> unsortedList = unsorted.ToList();

            double[] test1 = new double[unsortedList.Count];

            for (int i = 0; i < unsortedList.Count; i++)
            {
                test1[i] = double.Parse(unsortedList[i]);
                Console.WriteLine(test1[i]);
            }

            Console.WriteLine("\n");
            List<double> test = test1.ToList();
            test.Sort();

            string[] result = new string[test.Count];

            for (int i = 0; i < unsortedList.Count; i++)
            {
                result[i] = test[i].ToString();
                Console.WriteLine(result[i]);
            }

            // result is sorted but want to remove scientific notion! 
            // double has a precision of 15 to 17 digits.
            // decimal has a precision of 28 to 29 digits.
        }
    }
}


//int[] numbers = new int[] { 1, 3, 5, 7, 9 };
//string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//List<string> students = new List<string>();
//students.Add("Sue");
//students.Add("Bill");
//students.Add("Sven");

//foreach (string student in students) 
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine(students[0]);
//Console.WriteLine(students[1]);
//Console.WriteLine(students.Count);

//string[] studentArray = students.ToArray();
//Console.WriteLine(studentArray.Length);

//List<string> students2 = new List<string>(studentArray);
//students2.Add("Shelly");

//foreach (string student in students2)
//{
//    Console.WriteLine(student);
//}






//string[] students1 = new string[] { "Sue", "Bill", "Sven" };

//students1 = Collection.update(students1, 1, "Jesus");

//foreach (string student in students1)
//{
//    Console.WriteLine(student);
//}