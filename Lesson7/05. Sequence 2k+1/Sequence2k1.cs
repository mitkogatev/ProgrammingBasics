using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Sequence2k1
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i=i*2+1)
            //{
            //    Console.WriteLine(i);
            //}
            var num = 1;
            while (num<=n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
