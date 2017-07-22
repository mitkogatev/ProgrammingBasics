using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            int sleeps = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var apartmentPrice = 0.0;
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50*(sleeps>14?0.7:sleeps>7?0.95:1) * sleeps;
                    apartmentPrice = 65 * sleeps;
                    break;
                case "june":
                case "september":
                    studioPrice = 75.20*(sleeps > 14 ? 0.80 :1) * sleeps;
                    apartmentPrice = 68.70 * sleeps;
                    break;
                case "july":
                case "august":
                    studioPrice = 76 * sleeps;
                    apartmentPrice = 77 * sleeps;
                    break;
                default:
                    studioPrice = 0.0;
                    apartmentPrice = 0.0;
                    break;
            }
            if (sleeps > 14) apartmentPrice *= 0.90;
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
