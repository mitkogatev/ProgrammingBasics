using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTom
{
    class SleepyTom
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            var result = restDays * 127 + (365 - restDays) * 63;
            var diff = Math.Abs(result - 30000);
            //var mins = diff % 60;
            //Console.WriteLine(mins);
            if (result <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", diff / 60, diff % 60);
            }
        }
    }
}
