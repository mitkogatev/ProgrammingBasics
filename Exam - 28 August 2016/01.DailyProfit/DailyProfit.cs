using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            int workDaysPerMonth = int.Parse(Console.ReadLine());
            double salaryPerDay = double.Parse(Console.ReadLine());
            double dollarCoure = double.Parse(Console.ReadLine());

            var monthlySalary = workDaysPerMonth * salaryPerDay;
            double sum = (monthlySalary * 12 + monthlySalary * 2.5)*0.75;
            double levas = sum * dollarCoure;
            Console.WriteLine($"{levas/365:f2}");
        }
    }
}
