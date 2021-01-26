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