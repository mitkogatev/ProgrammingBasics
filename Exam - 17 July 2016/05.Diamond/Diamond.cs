using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 5 * n;
            int h = 3 * n + 2;
            for (int i = n; i > 0; i--)
            {
                if (i==n)
                    Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', w - 2 - 2 * i));
                    else
                Console.WriteLine("{0}*{1}*{0}",new string('.',i),new string('.',w-2-2*i));
            }
            Console.WriteLine(new string('*',w));
            for (int i = 1; i <= 2*n+1; i++)
            {
                if (i==2*n+1)
                    Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', w - 2 - 2 * i));

                else
                    Console.WriteLine("{0}*{1}*{0}",new string('.',i),new string('.',w-2-2*i));

            }
        }
    }
}
