using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int numPuzzels= int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            var profit = numPuzzels * 2.6 + numDolls * 3.00 + numBears * 4.10 + numMinions * 8.20 + numTrucks * 2.00;
            if (numPuzzels + numDolls + numBears + numMinions + numTrucks >= 50)
                profit *= 0.75;
            profit *= 0.9;
            if (tripPrice<=profit)
                Console.WriteLine($"Yes! {profit-tripPrice:f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
           
        }
    }
}
