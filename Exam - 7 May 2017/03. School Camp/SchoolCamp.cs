using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string groupType= Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            string sport="";
            //13:55 pause
            //14:02 resume


            if (season == "winter")
            {

                if (groupType == "boys") { sport = "Judo"; price = 9.60; }
                else if (groupType == "girls") { sport = "Gymnastics"; price = 9.60; }
                else { sport = "Ski"; price = 10; }
            }
            else if (season == "spring")
            {

                if (groupType == "boys") { sport = "Tennis"; price = 7.20; }
                else if (groupType == "girls") { sport = "Athletics"; price = 7.20; }
                else { sport = "Cycling"; price = 9.50; }
            }
            else
            {
                if (groupType == "boys") { sport = "Football"; price = 15; }
                else if (groupType == "girls") { sport = "Volleyball"; price = 15; }
                else { sport = "Swimming"; price = 20; }
            }

            var total = price * nights * students;
            if (students >= 50) { total *= 0.5; }
            else if (students < 50 && students >= 20) { total *= 0.85; }
            else if (students < 20 && students >= 10) { total *= 0.95; }
            Console.WriteLine($"{ sport} { total:f2} lv.");
           
        }
    }
}
