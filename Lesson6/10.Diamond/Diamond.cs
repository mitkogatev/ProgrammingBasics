using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = n % 2 == 0 ? 2 : 1;

            int h  = n % 2 == 0 ? n-1 : n;
            for (int i = 0; i <= h/2; i++)
            {
                if (i == 0 )
                    Console.WriteLine("{1}{0}{1}", new string('*', stars), new string('-', (n - stars) / 2));
                else
                { 
                    Console.WriteLine("{1}*{0}*{1}", new string('-', stars), new string('-', (n - stars - 2) / 2));
                    stars += 2; 
                }

            }
            stars -= 2;
            for (int i =0; i <h/2; i++)
            {
                if (i == h / 2 - 1)
                    Console.WriteLine("{1}{0}{1}", new string('*', stars), new string('-', (n - stars) / 2));
                else
                {
                    stars -= 2;
                    Console.WriteLine("{1}*{0}*{1}", new string('-', stars), new string('-', (n - stars - 2) / 2));

                }
                //Console.WriteLine("{1}*{0}*{1}", new string('-', stars), new string('-', (n - stars - 2) / 2));

            }
        }
    }
}
