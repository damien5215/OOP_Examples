using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public int NoOfLegs;
        
        public virtual string phonation() 
        {
            return "";
        }
    }

    public class Dog : Animal
    {
        public Dog() 
        {
            NoOfLegs = 4;
        }

        public override string phonation()
        {
            return "Bark";
        }
    }
    public class Cat : Animal
    {
        public Cat()
        {
            NoOfLegs = 4;
        }
        public override string phonation()
        {
            return "Meow";
        }
    }
}

//Animal Jeff = new Animal();
//Console.WriteLine(Jeff.NoOfLegs);
//Console.WriteLine(Jeff.phonation());
