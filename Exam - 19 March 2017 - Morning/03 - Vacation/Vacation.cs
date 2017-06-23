using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string restPlace="";

            if (budget > 3000)
            {
                restPlace = "Hotel";
                budget *= 0.9;
            }
            else if (budget > 1000 && budget <= 3000  )
            {
                restPlace = "Hut";
                budget *= season == "summer" ? 0.8 : 0.6;
            }
            else if (budget <= 1000)
            {
                restPlace = "Camp";
                budget *= season == "summer" ? 0.65 : 0.45;
            }

        var location= season == "summer" ? "Alaska" : "Morocco";
            Console.WriteLine($"{location} - {restPlace} - {budget:f2}");
        }
    }
}
