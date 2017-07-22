using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.division
{
    class division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum= int.Parse(Console.ReadLine());
                if (currentNum % 2 == 0) p1++;
                 if (currentNum % 3 == 0) p2++;
                 if (currentNum % 4 == 0) p3++;

            }
            Console.WriteLine("{0:f2}%",(double)p1/n*100);
            Console.WriteLine("{0:f2}%",(double)p2/n*100);
            Console.WriteLine("{0:f2}%",(double)p3/n*100);
        }
    }
}
