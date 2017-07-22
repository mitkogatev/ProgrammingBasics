using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            if (people >= 1 && people <= 4) budget *= 0.25;
            else if (people >= 5 && people <= 9) budget *= 0.40;
            else if (people >= 10 && people <= 24) budget *= 0.50;
            else if (people >= 25 && people <= 49) budget *= 0.60;
            else if (people >= 50 ) budget *= 0.75;

            var price = category == "vip" ? 499.99*people : 249.99*people;
            if (budget>=price)
                Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");

        }
    }
}
