using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 0)
            {
                if (args[0] == "1")
                {
                    Console.WriteLine("");
                    return int.Parse(args[0]);
                }
            }
            Process process = new Process();
            process.StartInfo.FileName = "calc.exe";
            process.StartInfo.Arguments = "1";

            process.Start();
            process.WaitForExit();

            Console.WriteLine("Child process is over!");
            Console.WriteLine("Child processs ExitCode: {0}", process.ExitCode);

            return 0;
        }
    }
}
