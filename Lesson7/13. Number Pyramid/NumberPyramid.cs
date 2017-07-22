using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var c = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                   if (j>1)
                    Console.Write(" ");
                    Console.Write(c);
                    c++;
                    if (c > n) break;
                }
                Console.WriteLine();
                if (c > n) break;
            }

        }
    }
}
