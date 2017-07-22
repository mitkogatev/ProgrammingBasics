using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;int p2 = 0;int p3 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;

            }
            Console.WriteLine($"{(double)p1/n*100:f2}%");
            Console.WriteLine($"{(double)p2/n*100:f2}%");
            Console.WriteLine($"{(double)p3/n*100:f2}%");
        }
    }
}
