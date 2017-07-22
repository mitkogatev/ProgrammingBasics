using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class SumThreeNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //if (a+b==c || a+c==b || b+c==a)
            //   Console.WriteLine("");
            if (a + b == c) Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            else if(c+a==b) Console.WriteLine("{0} + {1} = {2}",Math.Min(a,c), Math.Max(a, c), b);
            else if(c+b==a) Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
            else Console.WriteLine("No");
        }
    }
}
