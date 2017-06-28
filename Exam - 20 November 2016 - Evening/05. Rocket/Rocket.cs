using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 3 * n;
            int dots = (w - 2) / 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',dots),new string(' ',i*2));
                dots--;
            }
            dots++;
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', w-(2*dots)));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', dots), new string('\\', w-(2*dots)-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.', dots),new string('*', w - (2 * dots) - 2));
            dots--;
            }
        }
    }
}
