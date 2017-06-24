using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___SoftUni_Logo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var height = 4 * n - 2;
            var width = 12 * n - 5;
            int c = 0;
            for (int i = 1; i <=width; i+=6)
            {
                Console.WriteLine("{0}{1}{0}",new string('.',(width-i)/2),new string('#',i));
                c++;
            }
            int d = 3;
            for (int i = c; i < height-n; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string('.',d-1),new string ('#',width-(d*2)), new string('.', d));
                d += 3;
                
            }
            for (int i = 1; i <= n; i++)
            {
                if (i==n)
                    Console.WriteLine("@{0}{1}{2}", new string('.', d - 1), new string('#', width - (d * 2)), new string('.', d));
                else
                Console.WriteLine("|{0}{1}{2}", new string('.', d - 1), new string('#', width - (d * 2)), new string('.', d));

            }
        }
    }
}
