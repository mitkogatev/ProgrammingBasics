using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0.00;
            for (int i = 0; i < months; i++)
            {
                electricity += double.Parse(Console.ReadLine());
            }
            double water = 20.0 * months;
            double internet = 15.00 * months;
            double others = (electricity + water + internet) * 1.2;
            double average = (electricity + water + internet + others) / months;

Console.WriteLine($"Electricity: {electricity:f2} lv");
Console.WriteLine($"Water: {water:f2} lv");
Console.WriteLine($"Internet: {internet:f2} lv");
Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
