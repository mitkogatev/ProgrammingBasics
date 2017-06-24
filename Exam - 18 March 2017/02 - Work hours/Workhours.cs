using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Work_hours
{
    class Workhours
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var numWorkers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var workedHours = numWorkers * workDays * 8;
            if (neededHours <= workedHours)
            {
                Console.WriteLine($"{workedHours - neededHours} hours left");
            }
            else
            {
                Console.WriteLine($"{neededHours-workedHours} overtime");
                Console.WriteLine($"Penalties: {(neededHours - workedHours)*workDays}");
            }
        }
    }
}
