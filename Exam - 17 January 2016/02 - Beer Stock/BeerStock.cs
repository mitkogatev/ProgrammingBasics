using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Beer_Stock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            long reservedBeers = long.Parse(Console.ReadLine());
            var input = "";
            long shippedBeers = 0;
            while (input !="Exam Over")
            {
                input = Console.ReadLine();
                if (input == "Exam Over") break;
                var line = input.Split(' ');
                long amount = long.Parse(line[0]);
                string type = line[1];
                switch (type)
                {
                    case "beers": shippedBeers += amount;break;
                    case "sixpacks": shippedBeers += amount*6;break;
                    case "cases": shippedBeers += amount*24;break;

                }
            }

            shippedBeers -= shippedBeers / 100;
            long res = Math.Abs(reservedBeers - shippedBeers);
            long cases = res / 24;
            long six = (res % 24) / 6;
            long b = (res % 24) % 6;
            //Console.WriteLine(res);
            //Console.WriteLine("cases:{0},sixpacks={1},Beers={2}",cases,six,b);
            if (reservedBeers<=shippedBeers)
                Console.WriteLine($"Cheers! Beer left: {cases} cases, {six} sixpacks and {b} beers.");
            else
                Console.WriteLine($"Not enough beer. Beer needed: {cases} cases, {six} sixpacks and {b} beers.");

        }
    }
}
