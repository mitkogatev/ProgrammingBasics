using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            int currentSum = 0;
            int maxDiff = 0;
            for (int i = 1; i <= n*2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                currentSum += currentNumber;
                if (i % 2 == 0)
                {
                    if (maxSum == int.MinValue) maxSum = currentSum;//first pair
                    else if (maxSum != currentSum)
                    {
                        maxDiff = Math.Abs(maxSum - currentSum);
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                }

            }

            if (maxDiff==0)
            Console.WriteLine($"Yes, value={maxSum}");
            else
                Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
