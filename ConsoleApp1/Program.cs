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
            //FibConsole.MenuFunction();

            List<string> students = new List<string>();
            students.Add("Sue");
            students.Add("Bill");
            students.Add("Sven");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students.Count);

            string[] studentArray = students.ToArray();
            Console.WriteLine(studentArray.Length);

            List<string> students2 = new List<string>(studentArray);
            students2.Add("Shelly");

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
        }
    }
}

//FibConsole.MenuFunction();
//int[] arr = { 17, 2, 34, 48, 25 };

//int[] arr = {3, 6, 2, 5};
//Bubble bubble1 = new Bubble();
//bubble1.Sort2(arr);
