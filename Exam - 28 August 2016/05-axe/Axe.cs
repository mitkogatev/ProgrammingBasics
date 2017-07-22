using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 5 * n;
            int i = 0;
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',n*3), new string('-', i), new string('-', w-2-n*3-i));

            }
            i--;
            for (int j = 0; j < n/2; j++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', n * 3), new string('-', i), new string('-', w - 2 - n * 3 - i));

            }
            int startDashes = n * 3;
            for (int j = 0; j < n/2; j++)
            {

                if (j==n/2-1)
                    Console.WriteLine("{0}*{1}*{2}", new string('-', startDashes), new string('*', i), new string('-', w - 2 - startDashes - i));
                    else
                Console.WriteLine("{0}*{1}*{2}", new string('-', startDashes), new string('-', i), new string('-', w - 2 - startDashes - i));
                i+=2;
                startDashes--;
            }
           
            
            //Console.WriteLine("{0}*{1}*{2}", new string('-', startDashes), new string('*', i), new string('-', w - 2 - startDashes - i));

        }
    }
}
