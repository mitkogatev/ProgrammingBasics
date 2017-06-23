using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = n / 2 + 4;
            int w = 2 * n - 1;
            //first line
            Console.WriteLine("@{0}@{0}@",new string(' ',n-2));
            //second
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            //mid
            int j=1;
            int i = 0;
            int space = n -5;
            for ( i = 1; i <= n/2-2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.',i),new string(' ',space),new string('.',j));
                space -= 2;
                j += 2;   
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', i), new string('.', j));
            i++;
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', i),new string('*',(w-(3+2*i))/2 ) );
            Console.WriteLine(new string('*',w));
            Console.WriteLine(new string('*', w));


        }
    }
}
