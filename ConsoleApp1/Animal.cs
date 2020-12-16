using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public int NoOfEyes { get; } = 2;
        
        // Property is abstract therefore every sub-class will have to override.
        public abstract int NoOfLegs { get; protected set; }
        
        public virtual string phonation() 
        {
            return "";
        }
    }

    public class Dog : Animal
    {
        public override int NoOfLegs { get; protected set; }

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
        public override int NoOfLegs { get; protected set; }

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

//Animal Jeff = new Cat();
//Console.WriteLine(Jeff.NoOfEyes);
//Console.WriteLine(Jeff.NoOfLegs);
//Console.WriteLine(Jeff.phonation());
