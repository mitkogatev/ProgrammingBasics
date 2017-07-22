using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Perfect_Girlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            string input = "";
            //int day = 0;
            //int sum = 0;
            int count = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Enough dates!") break;
                int day = 0;
                int sum = 0;
                var line = input.Split('\\');
                switch (line[0].ToLower())
                {
                    case "monday":day = 1;break;
                    case "tuesday":day = 2;break;
                    case "wednesday":day = 3;break;
                    case "thursday":day = 4;break;
                    case "friday":day = 5;break;
                    case "saturday":day = 6;break;
                    case "sunday":day = 7;break;
                }
                //var n = int.Parse(line[1]);
                foreach (var item in line[1].ToArray())
                {
                    sum += int.Parse(item.ToString());
                }
                sum += day;
                //var nz = a[a.Length - 1];
                //var nz2 = a.Remove(a.Length - 1);
                int bnum = (int)line[2][line[2].Length - 1];
                sum += int.Parse(line[2].Remove(line[2].Length - 1)) * bnum ;
                sum -= (int)line[3][0] * line[3].Length;
                // Console.WriteLine(sum);
                if (sum >= 6000) {
                    Console.WriteLine($"{line[3]} is perfect for you.");
                    count++;
                    //Console.WriteLine(sum);
                }
                else Console.WriteLine($"Keep searching, {line[3]} is not for you.");

            }
            Console.WriteLine(count);
        }
    }
}
