using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Phil";
            person1.DOB_Year = 1954;
            person1.PhoneNo = "01912428449";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.DOB_Year);
            Console.WriteLine(person1.PhoneNo);

        }
    }
}

//FibConsole.MenuFunction();
