using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine().ToLower();
            var taxes = 0.0;
            switch (trace)
            {
                case "trail": taxes += juniors * 5.50 + seniors * 7.00;break;
                case "cross-country": taxes += juniors * 8.00 + seniors * 9.50;break;
                case "downhill": taxes += juniors * 12.25 + seniors * 13.75;break;
                case "road": taxes += juniors * 20.00 + seniors * 21.50;break;
            }
            if (trace == "cross-country" && juniors + seniors >= 50) taxes *= 0.75;
            taxes *= 0.95;
            Console.WriteLine($"{taxes:f2}");
        }
    }
}
