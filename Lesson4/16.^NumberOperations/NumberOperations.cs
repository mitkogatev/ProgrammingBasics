using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._NumberOperations
{
    class NumberOperations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (n2 == 0 && (op=="/"||op=="%")) {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }
            if (op == "+" || op == "-" || op == "*")
            {
                double result = op == "+" ? n1 + n2 : op == "-" ? n1 - n2 : n1 * n2;
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, op, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            else if (op == "/") Console.WriteLine("{0} {1} {2} = {3:f2}",n1,op,n2,(double)n1/n2);
            else Console.WriteLine("{0} {1} {2} = {3}", n1, op, n2, n1 % n2);
        }
    }
}
