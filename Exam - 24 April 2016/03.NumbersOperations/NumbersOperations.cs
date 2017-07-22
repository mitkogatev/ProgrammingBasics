using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NumbersOperations
{
    class NumbersOperations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            var op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2} - {3}",n1,n2,n1+n2,(n1+n2)%2==0?"even":"odd");
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2} - {3}", n1, n2, n1 - n2, (n1 - n2) % 2 == 0 ? "even" : "odd");
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2} - {3}", n1, n2, n1 * n2, (n1 * n2) % 2 == 0 ? "even" : "odd");
                    break;
                case "/":
                    if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                    else
                        Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, (double)n1 / n2);

                    break;
                case "%":
                    if (n2 == 0) Console.WriteLine($"Cannot divide {n1} by zero");
                    else
                        Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);

                    break;

            }
        }
    }
}
