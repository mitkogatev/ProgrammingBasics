using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();
            double price = 0.0;
            switch (season)
            {
                case "spring":
                case "summer": price += hrizantemi * 2.00 + roses * 4.10 + tulips * 2.50;break;

                case "autumn":
                case "winter": price += hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15;break;
            }
            price *= holiday == "y" ? 1.15 : 1;
            if (tulips > 7 && season == "spring")
                price *= 0.95;
            if (roses >= 10 && season == "winter")
                price *= 0.90;
            if (hrizantemi + roses + tulips > 20)
                price *= 0.80;
            Console.WriteLine($"{price+2:f2}");
        }
    }
}
