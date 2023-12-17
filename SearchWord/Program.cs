using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            string searchWord = args[1];
            int count = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    count += CountWord(line, searchWord);
                }
            }

            Console.WriteLine($"The word \"{searchWord}\" appears \"{count}\" times.");
        }
        static int CountWord(string text, string searchWord)
        {
            int count = 0;
            int index = text.IndexOf(searchWord, StringComparison.Ordinal);
            while (index >= 0)
            {
                count++;
                index = text.IndexOf(searchWord, index + searchWord.Length, StringComparison.OrdinalIgnoreCase);
            }
            return count;
        }
    }
}
