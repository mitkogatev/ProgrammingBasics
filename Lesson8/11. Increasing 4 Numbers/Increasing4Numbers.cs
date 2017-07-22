using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int n1 = start; n1 < end; n1++)
            {
                for (int n2 = n1+1; n2 < end; n2++)
                {
                    for (int n3 = n2+1; n3 < end; n3++)
                    {
                        for (int n4 = n3+1; n4 <= end; n4++)
                        {
                            Console.WriteLine($"{n1} {n2} {n3} {n4}");
                        }
                    }
                }
            }
            if (end < start + 3) Console.WriteLine("No");
        }
    }
}
