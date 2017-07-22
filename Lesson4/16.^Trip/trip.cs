using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Trip
{
    class trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string location;
            string restPlace;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    restPlace = "Camp";
                    budget *= 0.3;
                }
                else
                {
                    restPlace = "Hotel";
                    budget *= 0.7;
                }
                location = "Somewhere in Bulgaria";
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    restPlace = "Camp";
                    budget *= 0.4;
                }
                else
                {
                    restPlace = "Hotel";
                    budget *= 0.8;
                }
                location = "Somewhere in Balkans";
            }
            else
            {
                restPlace = "Hotel";
                budget *= 0.9;
                location = "Somewhere in Europe";
            }
            Console.WriteLine(location);
            Console.WriteLine($"{restPlace} - {budget:f2}");
        }
    }
}
