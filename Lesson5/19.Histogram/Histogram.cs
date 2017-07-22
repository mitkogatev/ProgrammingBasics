using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;int p4 = 0;int p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum= int.Parse(Console.ReadLine());
                if (currentNum < 200) p1++;
                else if (currentNum >= 200 && currentNum < 400) p2++;
                else if (currentNum >= 400 && currentNum < 600) p3++;
                else if (currentNum >= 600 && currentNum < 800) p4++;
                else p5++;


            }
            Console.WriteLine("{0:f2}",(double)p1/n*100);
            Console.WriteLine("{0:f2}",(double)p2/n*100);
            Console.WriteLine("{0:f2}",(double)p3/n*100);
            Console.WriteLine("{0:f2}",(double)p4/n*100);
            Console.WriteLine("{0:f2}",(double)p5/n*100);
        }
    }
}
