using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_5_Days
{
    class DateAfterFiveDays
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int maxDays = 0;
            switch (month)
            {
                case 2:maxDays = 28;break;
                case 4:
                case 6:
                case 9:
                case 11: maxDays = 30;break;
                default:maxDays = 31;break;
            }

            int newDay = 0;
            if (day + 5 > maxDays) { newDay = (day + 5) - maxDays; month++; }
            else newDay = day + 5;
            if (month > 12) month -= 12;
            Console.WriteLine($"{newDay}.{month:d2}");
        }
    }
}
