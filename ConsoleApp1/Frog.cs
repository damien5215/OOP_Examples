using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Frog
    {
        public readonly int TongueLength;

        public Frog(int tongueLength) 
        {
            TongueLength = tongueLength;
        }

        public static double GetAverageTongueLength(Frog[] frogs) 
        {
            double Total = 0;

            for (int i = 0; i < frogs.Length; i++) 
            {
                Total += frogs[i].TongueLength;
            }
            return (Total / frogs.Length);
        }
    }
}

//Frog frog1 = new Frog(4);
//Frog frog2 = new Frog(3);
//Frog frog3 = new Frog(6);
//Frog frog4 = new Frog(2);
//Frog frog5 = new Frog(4);
//Frog frog6 = new Frog(5);

//Frog[] frogs = new Frog[] { frog1, frog2, frog3, frog4, frog5, frog6 };

//double result = Frog.GetAverageTongueLength(frogs);

//Console.WriteLine("There are " + frogs.Length + " frogs." + "\n");
//Console.WriteLine("Average tongue length is " + result + "\n");
