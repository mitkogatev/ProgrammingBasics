using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Passion_Days
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal startMoney = decimal.Parse(Console.ReadLine());
            int purchases = 0;
            decimal price = 0.0m;
            string input = "";
            while (input != "mall.Enter")
            //while (input!= "mall.Exit")
            {
                input = Console.ReadLine();
            }
                //input = Console.ReadLine();
                if (input == "mall.Enter")
                {
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input == "mall.Exit") break;
                        foreach (char c in input)
                        {
                        price = 0.00m;
                         //(int)c * 0.5m
                        if (char.IsUpper(c)) price= (int)c * 0.5m;//startMoney -= (int)c * 0.5m;
                        else if (char.IsLower(c)) price=(int)c * 0.3m;
                            else if (c == '%') price=startMoney / 2;
                            else if (c == '*') startMoney += 10.0m;
                            else price = (int)c;
                        if (c != '*' && price <= startMoney && (startMoney-price)>=0 && startMoney>0)  { purchases++; startMoney -= price; }
                        }
                    }
                }
                 
                   
            //}
            if (purchases ==0)
            {
                Console.WriteLine($"No purchases. Money left: {startMoney:f2} lv.");
            }
            else
            Console.WriteLine($"{purchases} purchases. Money left: {startMoney:f2} lv.");

        }
    }
}
