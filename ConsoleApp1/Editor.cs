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
            string splitOn = " ";
            string[] wordArray = input.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string result = input + "\n" + "\n" + "Total number of words = " + wordArray.Length;

            return result;
        }

        public string SentenceCount(string input)
        {
            string splitOn = ".";
            string[] sentenceArray = input.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string result = input + "\n" + "\n" + "Total number of sentences = " + sentenceArray.Length;

            return result;
        }

        public string WordSenCount(string input) 
        {
            int totalWords = 0;
            string splitOn = ".";

            string result = input.Replace('?', '.').Replace('!', '.').Replace(". ", ".");

            string[] sentenceArray = result.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int[] wordArr = new int[(sentenceArray.Length)];

            result = result + "\n" + "\n";

            for (int i = 0; i < sentenceArray.Length; i++)
            {
                wordArr[i] = sentenceArray[i].Split(' ').Length;
                totalWords += wordArr[i];
                result += "Sentence " + (i + 1) + " contains " + wordArr[i] + " words." + "\n";
            }
            result = result + "\n" + "Total words = " + totalWords;

            return result;
        }
    }
}

//string input = "one two. three. four five six. seven. eight nine. ten.";

//Editor edit = new Editor();

//Console.WriteLine(edit.WordSenCount(input));
//Console.WriteLine(edit.WordCount(input));
//Console.WriteLine(edit.SentenceCount(input));
