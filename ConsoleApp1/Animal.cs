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
        public abstract bool UnihemisphericSleep { get; protected set; }

        public virtual string phonation() 
        {
            return "";
        }
    }

    public class Dog : Animal
    {
        public override bool UnihemisphericSleep { get; protected set; }

        public Dog() 
        {
            UnihemisphericSleep = false;
        }

        public override string phonation()
        {
            return "Bark";
        }
    }
    public class Dolphin : Animal
    {
        public override bool UnihemisphericSleep { get; protected set; }

        public Dolphin()
        {
            UnihemisphericSleep = true;
        }

        public override string phonation()
        {
            return "Clicks, whistles, etc";
        }
    }
}

//Animal Paul = new Dog();
//Console.WriteLine(Paul.NoOfEyes);
//Console.WriteLine(Paul.UnihemisphericSleep);
//Console.WriteLine(Paul.phonation() + "\n");

//Animal Jeff = new Dolphin();
//Console.WriteLine(Jeff.NoOfEyes);
//Console.WriteLine(Jeff.UnihemisphericSleep);
//Console.WriteLine(Jeff.phonation() + "\n");
