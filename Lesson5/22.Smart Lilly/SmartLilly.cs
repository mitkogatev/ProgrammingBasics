using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Smart_Lilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            /// JUDGE: https://judge.softuni.bg/Contests/Practice/Index/511#1
            int lilyAge = int.Parse(Console.ReadLine());
            double washMachine = double.Parse(Console.ReadLine());
            int toyPrice= int.Parse(Console.ReadLine());
            int toys = 0;
            double money = 0.0;
            double currMoney=0.0;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 != 0) toys++;
                else
                {
                    currMoney += 10.00;
                    money += currMoney-1;
                }
            }
            money += toys * toyPrice;
            if (money>=washMachine)
            Console.WriteLine("Yes! {0:f2}",money-washMachine);
            else
                Console.WriteLine("No! {0:f2}", washMachine-money);

        }
    }
}
