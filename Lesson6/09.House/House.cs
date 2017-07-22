using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = n % 2 == 0 ? 2 : 1;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{1}{0}{1}", new string('*', stars), new string('-', (n - stars) / 2));
                stars += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
