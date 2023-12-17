using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process pr = new Process();

            string filePath = args[0]; 
            string searchWord = args[1];
            pr.StartInfo.FileName = "SearchWord.exe";
            pr.StartInfo.Arguments = $"\"{filePath}\", \"{searchWord}\"";
            pr.StartInfo.UseShellExecute = false;
            pr.StartInfo.RedirectStandardOutput = true;
            pr.Start();

            string output = pr.StandardOutput.ReadToEnd();

            Console.WriteLine(output);

            pr.WaitForExit();
        }
    }
}
