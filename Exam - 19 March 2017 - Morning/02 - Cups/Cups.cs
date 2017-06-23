using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int mustWorkCups = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = numWorkers * 8 * workDays;
            var workedCups = workHours / 5;
            if (workedCups<mustWorkCups)
                Console.WriteLine("Losses: {0:f2}",(mustWorkCups-workedCups)*4.20);
            else
                Console.WriteLine("{0:f2} extra money",(workedCups-mustWorkCups)*4.20);
        }
    }
}
