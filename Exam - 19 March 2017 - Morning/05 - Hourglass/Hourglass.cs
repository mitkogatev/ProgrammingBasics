using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//5;//replace
            int hw = 2 * n + 1;//11

            Console.WriteLine(new string('*',hw));
            Console.WriteLine(".*{0}*.",new string(' ',hw-4));
            for (int i = 2; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',i),new string('@',hw-(i*2 +2)));
            }
            Console.WriteLine("{0}*{0}",new string('.',hw/2) );
            int j = 0;
            for (int i = (hw-3)/2; i >= 2; i--)
            {
               
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', i),new string(' ',j) );
                j++;
            }
            Console.WriteLine(".*{0}*.",new string('@',hw-4));
            Console.WriteLine(new string('*', hw));

        }
    }
}
