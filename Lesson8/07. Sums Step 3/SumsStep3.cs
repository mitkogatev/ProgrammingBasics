using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class SumsStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0, sum2 = 0, sum3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 1 || (i - 1) % 3 == 0) sum1 += num;
                if (i == 2 || (i - 2) % 3 == 0) sum2 += num;
                if (i == 3 || (i - 3) % 3 == 0) sum3 += num;

            }
            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");
        }
    }
}
