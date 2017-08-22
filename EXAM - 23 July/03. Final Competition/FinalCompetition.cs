using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = Console.ReadLine().ToLower();

            double prize = 0.0;
            if (location == "bulgaria")
            { prize = score * dancers;
                if (season == "summer")
                    prize *= 0.95;
                else
                    prize *= 0.92;
            }
            else if (location == "abroad")
            {
                prize = dancers * score;
                prize *= 1.5;
                if (season == "summer")
                    prize *= 0.90;
                else
                    prize *= 0.85;
            }

            var charity = prize * 0.75;
            prize *= 0.25;
            var moneyPerDancer = prize / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");

        }
    }
}
