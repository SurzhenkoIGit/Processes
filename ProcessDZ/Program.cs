using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Process process = new Process();
                process.StartInfo.FileName = "ArgsOperations.cs";
                process.StartInfo.Arguments = "7 3 +";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                Task t = new Task(() =>
                {
                    process.Start();
                    string inParams = process.StartInfo.Arguments;
                    string str = process.StandardOutput.ReadLine();

                    Console.WriteLine("Result for data {0}: {1}", inParams, str);
                    process.WaitForExit();
                    process.Close();
                    process.Dispose();
                });
                t.Start();
            } while (true);
            //Console.ReadKey();
        }
            
    }
}
