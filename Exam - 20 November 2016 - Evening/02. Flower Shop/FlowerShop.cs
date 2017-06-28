using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnolies = int.Parse(Console.ReadLine());
            int ziumb = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            var profit = magnolies * 3.25 + ziumb * 4.00 + roses * 3.50 + cactuses * 8.00;

            profit *= 0.95;
            if (profit>=giftPrice)
                Console.WriteLine($"She is left with {Math.Floor(profit-giftPrice)} leva.");
            else
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice-profit)} leva.");
        }
    }
}
