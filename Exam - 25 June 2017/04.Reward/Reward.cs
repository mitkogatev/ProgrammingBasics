using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reward
{
    class Reward
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double rewardPerPoint = double.Parse(Console.ReadLine());
            var totalSum = 0.0;
            for (int i = 1; i <=parts; i++)
            {
                int points= int.Parse(Console.ReadLine());
                if (i % 2 == 0) points *= 2;
                totalSum += points * rewardPerPoint;
            }
            Console.WriteLine($"The project prize was {totalSum:f2} lv.");
        }
    }
}
