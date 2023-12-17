using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userchoise = "";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.Arguments = Console.ReadLine();
            process.Start();
            Console.WriteLine("Please, enter code of command: 1 - WaitForExit(), 2 - Kill()");
            userchoise = Console.ReadLine();
            int choise = int.Parse(userchoise);
            switch (choise)
            {
                case 1:
                    process.WaitForExit();
                    Console.WriteLine("Child process is over");
                    break;
                case 2:
                    process.Kill();
                    Console.WriteLine("Child process has been killed");
                    break;
            }
        }
    }
}
