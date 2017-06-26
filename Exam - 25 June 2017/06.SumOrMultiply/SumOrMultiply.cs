using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOrMultiply
{
    class SumOrMultiply
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());
            bool found=false;
            for (int a = 1; a <=30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if ((a < b && b < c) && a + b + c == controlNum)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {controlNum}");
                            found = true;
                        }
                        if ((a > b && b > c) && a * b * c == controlNum)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {controlNum}");
                            found = true;
                        }
                    }
                }
            }
            if (!found) Console.WriteLine("No!");
        }
    }
}
