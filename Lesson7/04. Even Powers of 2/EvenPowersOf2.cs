using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            //Console.WriteLine(num);
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine(num);
                num = num * 2*2;
                
            }
            Console.WriteLine(num);
        }
    }
}
