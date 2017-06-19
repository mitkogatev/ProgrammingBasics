using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            double km = double.Parse(Console.ReadLine());
            var salary=0.00;

            if (10000 < km && km <= 20000)
            {
                salary = 4 * km * 1.45;
            }

            else if (5000 < km && km <= 10000)
                switch (season)
                {
                    case "spring":
                    case "autumn":
                        salary = 4 * km * 0.95; break;
                    case "summer":
                        salary = 4 * km * 1.10; break;
                    default: salary = 4 * km * 1.25; break;
                }
            else
            {
                switch (season)
                {
                    case "spring":
                    case "autumn":
                        salary = 4 * km * 0.75; break;
                    case "summer":
                        salary = 4 * km * 0.90; break;
                    default: salary = 4 * km * 1.05; break;
                }
            }
            Console.WriteLine($"{salary*0.9:f2}");
            
            //    if (season=="spring" || season=="autumn")
            //{
               
            //}
                //09:10--break;;; started at 09:00//08:14 --start ||
                // 08:30 DONE !!!!!

        }
    }
}
