using System;

namespace _18.TransportPriceHomeWork
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();
            double minPrice;
            if (km >= 100)
            { minPrice = km * 0.06; }
            else if (km >= 20)
            {
                minPrice = km * 0.09;
            }
            else
            {
                if (timeOfDay == "day")
                {
                    minPrice = 0.70 + 0.79 * km;
                }
                else
                {
                    minPrice = 0.70 + 0.90 * km;
                }
            }
            Console.WriteLine("{0:f2}",minPrice);
        }
    }
}
