using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Hungry_Garfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQty = uint.Parse(Console.ReadLine());
            uint lasagnaQty = uint.Parse(Console.ReadLine());
            uint sandwichQty = uint.Parse(Console.ReadLine());

            var totMoney = money;
            decimal neededMoney = pizzaPrice/rate * pizzaQty + lasagnaPrice/rate * lasagnaQty + sandwichPrice/rate * sandwichQty;
            if (totMoney>=neededMoney)
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${Math.Abs(totMoney-neededMoney):f2}.");
            else
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${Math.Abs(neededMoney-totMoney):f2}.");

        }
    }
}
