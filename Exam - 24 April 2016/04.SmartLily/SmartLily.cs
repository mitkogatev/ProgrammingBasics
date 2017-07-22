using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLily
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice=double.Parse(Console.ReadLine());
            int toyPrice=int.Parse(Console.ReadLine());
            double money = 0;
            double incMoney = 0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    incMoney += 10;
                    money += incMoney - 1.00;
                }
                else toys++;
            }
            var totalMoney = money + (toys * toyPrice);
            var diff = Math.Abs(machinePrice - totalMoney);
            if(totalMoney>=machinePrice)
                Console.WriteLine($"Yes! {diff:f2}");
            else Console.WriteLine($"No! {diff:f2}");
        }
    }
}
