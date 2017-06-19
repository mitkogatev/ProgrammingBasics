using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//TODO: replace
            int h = 4 * n + 4;
            string mid = new string('~', n - 2);
            Console.WriteLine("+{0}+{1}",mid,new string('.',2*n+1));
            string pattern = "\\" + mid + "\\";
            for (int i = 0; i < h / 2 - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string('.',i),pattern, new string('.', 2 * n -i));
            }
            int j = 0;
            pattern = "|" + mid + "|";
            for (int i = h / 2 - 1; i > 0; i--)//i=11
            {
                Console.WriteLine("{0}\\{1}{2}",new string('.',j), new string('.', 2 * n - j),pattern);

                j++;

            }
            Console.WriteLine("{1}+{0}+", mid, new string('.', 2 * n + 1));

        }
    }
}
