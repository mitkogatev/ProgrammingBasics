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
            
                string input = "";
                while(true)
                {
                if (Console.ReadLine() == "mall.Enter")
                {
                    input = Console.ReadLine();
                    if (input == "mall.Exit") break;
                    foreach (char c in input)
                    {
                        if (char.IsUpper(c)) startMoney -= (int)c * 0.5m;
                        else if (char.IsLower(c)) startMoney -= (int)c * 0.3m;
                        else if (c == '%') startMoney /= 2;
                        else if (c == '*') startMoney += 10.0m;
                        else startMoney -= (int)c;
                        if (c != '*') purchases++;
                    }
                }
                 
                   
                Console.WriteLine("money:"+startMoney);
            }
        }
    }
}
