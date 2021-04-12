using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SequenceDetector
    {
        // Exmaple of property overriding.
        public virtual string Description => "Detects Sequences";
        
        public virtual bool Scan(int[] sequence)
        {
            Console.WriteLine("Sequence Detector");
            return false;
        }
    }

    public class RepeatDetector : SequenceDetector
    {
        // Exmaple of property overriding.
        public override string Description => "Detects Repeats";

        public override bool Scan(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] == sequence[i])
                {
                    Console.WriteLine("Repeat Detector");
                    Console.WriteLine("REPEAT DETECTED!");
                    return true;
                }
            }
            Console.WriteLine("Repeat Detector");
            Console.WriteLine("NO REPEAT DETECTED!");
            return false;
        }
    }
}

//int[] array1 = new int[] { 1, 3, 5, 1, 1, 9 };

//SequenceDetector SD2 = new SequenceDetector();
//bool result2 = SD2.Scan(array1);
//Console.WriteLine(result2);
//Console.WriteLine(SD2.Description + "\n" + "\n");


//SequenceDetector SD1 = new RepeatDetector();
//bool result = SD1.Scan(array1);
//Console.WriteLine(result);
//Console.WriteLine(SD1.Description);