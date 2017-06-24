using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Car_To_Go
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string clas = "";
            string car = "";
            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "summer") { budget *= 0.35; car = "Cabrio"; }
                else { budget *= 0.65; car = "Jeep"; }
            }
            else if (budget > 100 && budget<=500)
            {
                clas = "Compact class";
                if (season == "summer") { budget *= 0.45; car = "Cabrio"; }
                else { budget *= 0.80; car = "Jeep"; }
            }
            else if (budget > 500)
            {
                clas = "Luxury class";
                 budget *= 0.90; car = "Jeep"; 
            }

            Console.WriteLine($"{clas}");
            Console.WriteLine($"{car} - {budget:f2}");
        }
    }
}
