using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1; 
            int last = n;
            if (n == 1) { Console.WriteLine(1); return; }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(first+" ");
                first++;
                int tmp = first;
                int even = 2;

                for (int j = 1; j <= n-2; j++)
                {
                    if (tmp > n) { Console.Write(tmp-even+" "); even += 2; }
                    else
                    Console.Write(tmp+" ");
                    tmp++;
                }
                Console.Write(last);
                last--;
                Console.WriteLine();
            }
        }
    }
}
