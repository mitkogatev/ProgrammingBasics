using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int w = 4 * n + 1;
            int h = 2 * n + 5;
            Console.WriteLine("{0}/|\\{0}",new string('.',(w-3)/2));
            Console.WriteLine("{0}\\|/{0}", new string('.', (w - 3) / 2));
            Console.WriteLine("{0}***{0}", new string('.', (w - 3) / 2));
            for (int i = 1; i <= h-6; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',(w-(3+2*i))/2),new string('-', i) );
            }
            Console.WriteLine("{0}",new string('*',w));
            //Console.WriteLine("{0}");
            for (int i = 0; i < (w-1)/2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', w));

        }
    }
}
