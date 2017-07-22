using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._Tickets
{
    class Tickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());
            double sumLeft = 0.0;
            double price = category == "vip" ? 499.99*people : 249.99*people;
            if (people >= 1 && people <= 4) sumLeft = budget * 0.25;
            else if (people >= 5 && people <= 9) sumLeft = budget * 0.4;
            else if (people >= 10 && people <= 24) sumLeft = budget * 0.5;
            else if (people >= 25 && people <= 49) sumLeft = budget * 0.6;
            else sumLeft = budget * 0.75;

            if (sumLeft >= price) Console.WriteLine($"Yes! You have {(sumLeft-price):f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {(price-sumLeft):f2} leva.");
        }
    }
}
