using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Master_Herbalist
{
    class MasterHerbalist
    {
        static void Main(string[] args)
        {
            long expenses = long.Parse(Console.ReadLine());
            var input = "";
            int sum = 0;
            int days = 0;
            while (input != "Season Over")
            {
                input = Console.ReadLine();
                if (input == "Season Over") break;
                var line = input.Split(' ');
                int hours = int.Parse(line[0]);
                var path = line[1].ToCharArray();
                int price = int.Parse(line[2]);
                int c = 0;
                
                for (int i = 0; i < hours; i++)
                {
                    if (c == path.Length) c = 0;
                    if (path[c] == 'H') sum += price;
                    c++;
                }
                days++;
            }
            double avgPerDay = (double)sum / days;
            if (avgPerDay>=expenses)
            Console.WriteLine($"Times are good. Extra money per day: {avgPerDay-expenses:f2}.");
            else
                Console.WriteLine($"We are in the red. Money needed: {Math.Ceiling((expenses-avgPerDay) * days)}.");
        }
    }
}
