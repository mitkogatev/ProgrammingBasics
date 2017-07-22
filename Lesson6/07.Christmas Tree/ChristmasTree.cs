using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n;
            Console.WriteLine("{0} | {0}", new string(' ', spaces));
            for (int i = 1; i <= n; i++)
            {
                --spaces;
                Console.WriteLine("{1}{0} | {0}{1}",new string('*',i),new string(' ',spaces));
            }
        }
    }
}
