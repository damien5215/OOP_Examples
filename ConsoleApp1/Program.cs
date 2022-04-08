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
            //FibConsole.MenuFunction();

            string test01 = "'2374', '4343434',  '4343443', '34334443'";
            string test02 = test01.Replace(" ","");
            char[] charArray = test01.ToCharArray();

            for(int i = 0; i < charArray.Length; i++) 
            {
                Console.WriteLine(charArray[i]);
            }

            Console.WriteLine(test01);
            Console.WriteLine(test02);

        }
    }
}

