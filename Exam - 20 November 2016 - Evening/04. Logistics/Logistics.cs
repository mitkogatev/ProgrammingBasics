using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numStocks = int.Parse(Console.ReadLine());
            int bus = 0;
            int truck = 0;
            int train = 0;
            double all = 0;
            for (int i = 0; i < numStocks; i++)
            {
                var tmp = int.Parse(Console.ReadLine());
                if (tmp < 4) bus += tmp;
                if (tmp >= 4 && tmp < 12) truck += tmp;
                if (tmp >= 12) train += tmp;
                all += tmp;
            }
            Console.WriteLine("{0:f2}",(bus*200.0+truck*175.0+train*120.0)/all);
            Console.WriteLine($"{bus/all*100:f2}%");
            Console.WriteLine($"{truck/all*100:f2}%");
            Console.WriteLine($"{train/all*100:f2}%");

        }
    }
}
