using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AuthorName
    {
        public string getAuthorName(int number)
        {
            return (number == 1) ? "Sartre" : "Wittgenstein";
        }

        public string getAuthorName2(int number) 
        {
            if (number == 1)
            {
                return "Sartre";
            }
            else 
            {
                return "Wittgenstein";
            }
        }
    }
}

//AuthorName Name1 = new AuthorName();

//Console.WriteLine(Name1.getAuthorName(1) + "\n");
//Console.WriteLine(Name1.getAuthorName(2) + "\n");
//Console.WriteLine(Name1.getAuthorName2(1) + "\n");
//Console.WriteLine(Name1.getAuthorName2(2) + "\n");
