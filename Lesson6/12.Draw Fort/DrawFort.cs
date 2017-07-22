using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Draw_Fort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w= 2 * n;
            string topColumn = "/" + new string('^', n / 2)+"\\";
            Console.WriteLine("{0}{1}{0}",topColumn,new string('_',w-2*topColumn.Length));
            for (int i = 1; i <= n-2; i++)
            {
                if (i==n-2)
                    Console.WriteLine("|{0}{1}{0}|",new string(' ',n/2+1),new string('_', w - 2 * topColumn.Length));
                else
                Console.WriteLine("|{0}|",new string(' ',w-2));
            }
            string botColumn = "\\" + new string('_', n / 2) + "/";
            Console.WriteLine("{0}{1}{0}",botColumn, new string(' ', w - 2 * topColumn.Length));
        }
    }
}
