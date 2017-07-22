using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 2 * n - 1;
            Console.WriteLine("{0}*{0}", new string(' ',(w-1)/2));
            for (int i = 1; i < n; i++)
            {
                Console.Write("{0}*",new string(' ',(w-(i*2+1))/2 ));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int i = n-2; i >= 0; i--)
            {
                Console.Write("{0}*", new string(' ', (w - (i * 2 + 1)) / 2));
                for (int j = i-1; j >= 0; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
