using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());
                if (t < max) max = t;
            }
            Console.WriteLine(max);
        }
    }
}
