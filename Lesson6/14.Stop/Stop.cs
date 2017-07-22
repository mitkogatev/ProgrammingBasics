using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            //Judge:https://judge.softuni.bg/Contests/Practice/Index/513#2
            int n = int.Parse(Console.ReadLine());
            int startDots = n + 1;
            int w = 2 * startDots + 2 * n + 1;
            Console.WriteLine("{0}{1}{0}",new string('.',startDots),new string('_',2*n+1));
            for (int i = 0; i < n; i++)
            {
                startDots --;
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', startDots), new string('_', w-(2*startDots+4)));
            }
            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',(w-4-5)/2));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",new string('.',i),new string('_',w-4-2*i));
            }
        }
    }
}
