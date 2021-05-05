using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Editor
    {
        public string WordCount(string input) 
        {
            //input = "one two. three. four five six. seven. eight nine.";

            int totalWords = 0;
            string splitOn = ".";

            string result = input.Replace('?', '.').Replace('!', '.').Replace(". ", ".");


            string[] sentenceArray = result.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int[] wordArr = new int[(sentenceArray.Length)];

            for (int i = 0; i < sentenceArray.Length; i++)
            {
                wordArr[i] = sentenceArray[i].Split(' ').Length;
                totalWords += wordArr[i];
                result += "Sentence " + (i + 1) + " contains " + wordArr[i] + " words." + "\n";
            }

            return result;
        }
    }
}
