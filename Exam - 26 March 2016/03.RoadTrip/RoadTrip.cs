using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RoadTrip
{
    class RoadTrip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = "";
            string place = "";
            if (budget <= 100)
            {
                location = "Somewhere in Bulgaria";
                if (season == "summer") { place = "Camp"; budget *= 0.30; }
                else { place = "Hotel"; budget *= 0.70; }
            }
            else if (budget <= 1000 && budget > 100)
            {
                location = "Somewhere in Balkans";
                if (season == "summer") { place = "Camp"; budget *= 0.40; }
                else { place = "Hotel"; budget *= 0.80; }
            }
            else
            {
                location = "Somewhere in Europe";
                if (season == "summer") { place = "Hotel"; budget *= 0.90; }
                else { place = "Hotel"; budget *= 0.90; }
            }
            Console.WriteLine(location);
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}
