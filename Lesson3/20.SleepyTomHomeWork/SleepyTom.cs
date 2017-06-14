using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SleepyTomHomeWork
{
    class SleepyTom
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());//20
            var playTime = (365 - holidays) * 63 + holidays * 127;

            if (playTime > 30000)
            {
                var extraMinutes = playTime - 30000;
                var dt = TimeSpan.FromMinutes(extraMinutes);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Truncate(dt.TotalHours)} hours and {dt.Minutes} minutes more for play");
            }
            else
            {
                var extraMinutes = 30000-playTime;
                var dt = TimeSpan.FromMinutes(extraMinutes);
                Console.WriteLine("Tom sleeps well");
                
                Console.WriteLine($"{Math.Truncate(dt.TotalHours)} hours and {dt.Minutes} minutes less for play");
            }
        }
    }
}
