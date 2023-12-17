using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessDZ
{
    public class ArgsOperations
    {
        public enum EMathOper
        {
            None,
            Sum,
            Sub,
            Mult,
            Div
        }
        static EMathOper GetOperator(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return EMathOper.None;
            }
            if (str.Length != 1)
            {
                return EMathOper.None;
            }
            switch (str[0])
            {
                case '+':
                    return EMathOper.Sum;
                case '-':
                    return EMathOper.Sub;
                case '*':
                    return EMathOper.Mult;
                case '/':
                    return EMathOper.Div;
                default:
                    return EMathOper.None;
            }
        }

        static int Main(string[] args)
        {
            try
            {
                //foreach (var arg in args) 
                //{
                //    Console.Write("arg: {0} ", arg);
                //}
                int a, b, c;
                EMathOper eMath;
                a = int.Parse(args[0]);
                b = int.Parse(args[2]);
                System.Threading.Thread.Sleep(5000);
                eMath = GetOperator(args[1]);
                switch (eMath)
                {
                    case EMathOper.Sum:
                        Console.WriteLine(a + b);
                        break;
                    case EMathOper.Sub:
                        Console.WriteLine(a - b);
                        break;
                    case EMathOper.Mult:
                        Console.WriteLine(a * b);
                        break;
                    case EMathOper.Div:
                        Console.WriteLine(a / b);
                        break;
                }
                
                
                

                return 0;

            }
            catch
            {
                return 1;
            }
        }
    }
}
