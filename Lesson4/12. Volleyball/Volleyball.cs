using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekEndsHome= int.Parse(Console.ReadLine());
            double sofia = (48 - weekEndsHome) * (double)3/4;

            double plays = (holidays * (double)2 / 3) + weekEndsHome + sofia;
            if (year == "leap") plays *= 1.15;
            Console.WriteLine("{0}",Math.Truncate(plays));
        }
    }
}
