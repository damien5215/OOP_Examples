using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class String
    {
        public string Concatenate(string first, string second)
        {
            return "I think " + first + " and "
                    + second + " are good!";
        }
        public string Interpolate(string first, string second)
        {
            return $"I think {first} and {second} are good!";
        }
    }
}

//string r1 = "";
//string r2 = "";

//String string1 = new String();
//r1 = string1.Concatenate("Korn","Deftones");
//r2 = string1.Interpolate("Crazy Town", "Static X");

//Console.WriteLine(r1 + "\n");
//Console.WriteLine(r2 + "\n");
