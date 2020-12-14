using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        // This is a field.  It is private to your class and stores the actual data.
        private string _name;

        // This is a property. When accessed it uses the underlying field,
        // but only exposes the contract, which will not be affected by the underlying field
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax
        // used to generate a private field for you
        public int DOB_Year { get; set; }
    }
}

//Person person1 = new Person();
//person1.Name = "Phil";
//person1.DOB_Year = 1954;
//Console.WriteLine(person1.Name + " " + person1.DOB_Year);
