using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 4 * n + 1;
            int h = 2 * n + 1;
            //first line
            int space = 1;
            Console.WriteLine("{0}",new string('#',w));
            //
            int i = 0;
            for ( i = 1; i <=h-n-1; i++)
            {
                if (i==(h-n-1)/2 +1)
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",new string('.',i),new string('#',(w-(2*i+space))/2),new string(' ',(space-3)/2)   );

                else
                    Console.WriteLine("{0}{1}{2}{1}{0}",new string('.',i),new string('#',(w-(2*i+space))/2),new string(' ',space)   );
                space += 2;
            }
            //bottom n lines
            for (int j = i; j < i + n; j++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', j), new string('#', w - (2 * j)));
            }
        }
    }
}
