using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hotel_Room
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            int sleeps = int.Parse(Console.ReadLine());
            var studioPrice = 0.00;
            var apartmentPrice = 0.00;
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice += 50.0 * sleeps;
                    apartmentPrice += 65.0 * sleeps;
                    if (sleeps > 14) { studioPrice *= 0.7; apartmentPrice *= 0.9; }
                    else if (sleeps > 7) studioPrice *= 0.95;
                    break;
                case "june":
                case "september":
                    studioPrice += 75.20 * sleeps;
                    apartmentPrice += 68.70 * sleeps;
                    if (sleeps > 14) { studioPrice *= 0.8; apartmentPrice *= 0.9; }

                    break;
                case "july":
                case "august":
                    studioPrice += 76.0 * sleeps;
                    apartmentPrice += 77.0 * sleeps;
                    if (sleeps > 14) apartmentPrice *= 0.9; 

                    break;

            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
