using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine().ToLower();
            var price = 0.0;
            if (km >= 100)
                price = km * 0.06;
            else if (km < 100 && km >= 20)
                price = km * 0.09;
            else
            {
                price += 0.70;
                price += timeOfDay == "day" ? km*0.79 : km*0.90;
            }
            Console.WriteLine(price);
        }
    }
}
