using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var qty = double.Parse(Console.ReadLine());
            double price=0.0;
            if (product=="coffee")
            {
                if (city == "sofia") price = 0.5;
                else if (city == "plovdiv") price = 0.4;
                else if (city == "varna") price = 0.45;
            }
            if (product == "water")
            {
                if (city == "sofia") price = 0.8;
                else   price = 0.7;
            }
            if (product == "beer")
            {
                if (city == "sofia") price = 1.20;
                else if (city == "plovdiv") price = 1.15;
                else if (city == "varna") price = 1.10;
            }
            if (product == "sweets")
            {
                if (city == "sofia") price = 1.45;
                else if (city == "plovdiv") price = 1.30;
                else if (city == "varna") price = 1.35;
            }

            if (product == "peanuts")
            {
                if (city == "sofia") price = 1.60;
                else if (city == "plovdiv") price = 1.50;
                else if (city == "varna") price = 1.55;
            }

            Console.WriteLine(qty*price);
        }
    }
}
