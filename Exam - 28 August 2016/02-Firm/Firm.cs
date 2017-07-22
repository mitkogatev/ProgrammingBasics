using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double workHours = days * 8.0 * 0.9+(workers*2.0*days);
            
            if (neededHours <=workHours)
                Console.WriteLine($"Yes!{Math.Floor(workHours-neededHours)} hours left.");
            else
                Console.WriteLine($"Not enough time!{Math.Ceiling(neededHours-(double)workHours)} hours needed.");

        }
    }
}
