using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop_HOME
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var qty = double.Parse(Console.ReadLine());
            double price=0.0;
            int e = 0;
            if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.7; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.90; break;
                    case "grapefruit": price = 1.60; break;
                    case "kiwi": price = 3.00; break;
                    case "pineapple": price = 5.60; break;
                    case "grapes": price = 4.20; break;
                    default: price = 0.0; break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "banana": price = 2.5; break;
                    case "apple": price = 1.20; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.70; break;
                    case "pineapple": price = 5.50; break;
                    case "grapes": price = 3.85; break;
                    default: price = 0.0; break;
                }
            }

            string[] stringArray = { "monday", "tuesday", "wednesday",
                "thursday","friday","saturday","sunday"};
            int pos = Array.IndexOf(stringArray, day);
            if (pos == -1)
             e = 1;
                if (price==0.0 || e==1)
                Console.WriteLine("error");
                else
                Console.WriteLine("{0:f2}",price*qty);

         }
     }
}
        