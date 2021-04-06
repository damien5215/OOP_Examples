using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        // This is a field
        private string _name;

        // This is a property 
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

        // These are AutoProperties 
        public int DOB_Year { get; set; }
        public string PhoneNo { get; set; }
    }
}

//Person person1 = new Person();
//person1.Name = "Phil";
//person1.DOB_Year = 1954;
//person1.PhoneNo = 01912428449;
//Console.WriteLine(person1.Name + " " + person1.DOB_Year);
