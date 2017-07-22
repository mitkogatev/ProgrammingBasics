using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = n * 2;
            int column = n / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\",new string('^',column),new string('_',w-4-2*column));
            for (int i = 1; i <= n-2; i++)
            {
                if (i==n-2)
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n/2+1),new string('_',w-4-2*column));

                else
                    Console.WriteLine("|{0}|",new string(' ',w-2));
            }

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', column), new string(' ', w - 4 - 2 * column));

        }
    }
}
