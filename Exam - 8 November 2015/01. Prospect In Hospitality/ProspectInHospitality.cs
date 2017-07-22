using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prospect_In_Hospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            uint buildersNeeded = uint.Parse(Console.ReadLine());
            uint receptionistsNeeded = uint.Parse(Console.ReadLine());
            uint chambermaidsNeeded = uint.Parse(Console.ReadLine());
            uint techNeeded = uint.Parse(Console.ReadLine());
            uint othersNeeded = uint.Parse(Console.ReadLine());
            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal sum = buildersNeeded * 1500.04m + receptionistsNeeded * 2102.10m + chambermaidsNeeded * 1465.46m + techNeeded * 2053.33m + othersNeeded * 3010.98m;
            sum += nikiSalary * usdRate;
            sum += mySalary;
            Console.WriteLine($"The amount is: {sum:f2} lv.");
            if (sum <=budget)
                Console.WriteLine($"YES \\ Left: {budget - sum:f2} lv.");
            else
                Console.WriteLine($"NO \\ Need more: {sum - budget:f2} lv.");

        }
    }
}
