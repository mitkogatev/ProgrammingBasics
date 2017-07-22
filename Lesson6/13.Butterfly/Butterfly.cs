using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = 2 * (n - 2) + 1;
            for (int i = 1; i <= h/2; i++)
            {
                if (i%2==0)
                    Console.WriteLine("{0}\\ /{0}",new string('-',n-2));
                else
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
            }
            Console.WriteLine("{0}@",new string(' ',n-1));
            for (int i = 1; i <= h / 2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                else
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
            }
        }
    }
}
